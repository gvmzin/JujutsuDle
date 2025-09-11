using JujutsuDle.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Threading.Tasks; 

namespace JujutsuDle.Controllers
{
    public class JujutsuDleController : Controller
    {
        private readonly ICharacterService _characterService;
        private const string SessionKeyGuesses = "_Guesses";
        private const string SessionKeyAnswerId = "_AnswerId"; // Chave para guardar o ID do personagem sorteado

        public JujutsuDleController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        public async Task<IActionResult> Index()
        {
            CheckForNewDay();

            ViewBag.AllCharacterNames = await _characterService.GetAllCharacterNamesAsync();
            
            var guesses = GetGuessesFromSession();

            if (guesses.Any())
            {
                ViewData["Answer"] = await GetAnswerForCurrentGameAsync();
            }

            return View(guesses);
        }

        [HttpPost]
        public async Task<IActionResult> Guess(string characterName) 
        {
            var answer = await GetAnswerForCurrentGameAsync(); 
            
            var guess = await _characterService.FindCharacterByNameAsync(characterName);

            if (guess != null)
            {
                var result = CompareCharacters(guess, answer);
                var guesses = GetGuessesFromSession();
                guesses.Add(result);
                HttpContext.Session.SetString(SessionKeyGuesses, JsonSerializer.Serialize(guesses));
            }

            return RedirectToAction("Index");
        }
        [HttpPost] 
        public IActionResult Restart()
        {
            // Remove as informações do jogo atual da sessão do usuário.
            HttpContext.Session.Remove(SessionKeyGuesses); // Limpa o histórico de palpites
            HttpContext.Session.Remove(SessionKeyAnswerId); // Limpa o ID do personagem secreto

            // Redireciona o usuário de volta para a página principal, que agora estará limpa.
            return RedirectToAction("Index");
        }
        private async Task<Character> GetAnswerForCurrentGameAsync()
        {
            var characterId = HttpContext.Session.GetInt32(SessionKeyAnswerId);

            if (characterId == null)
            {
                // Sorteia um novo personagem se for o início do jogo
                var newAnswer = await _characterService.GetRandomCharacterAsync();
                HttpContext.Session.SetInt32(SessionKeyAnswerId, newAnswer.Id);
                return newAnswer;
            }
            else
            {
                // Busca o personagem pelo ID salvo na sessão se o jogo já começou
                return await _characterService.GetCharacterByIdAsync(characterId.Value);
            }
        }

        private GuessResultViewModel CompareCharacters(Character guess, Character answer)
        {
            var result = new GuessResultViewModel
            {
                GuessedName = guess.Name,
                PhotoUrl = guess.PhotoUrl,
            
                Gender = guess.Gender == answer.Gender ? ComparisonResult.Correct : ComparisonResult.Incorrect,
                GenderValue = guess.Gender.GetDisplayName(),

                Species = guess.Species == answer.Species ? ComparisonResult.Correct : ComparisonResult.Incorrect,
                SpeciesValue = guess.Species.GetDisplayName(),

                Classification = guess.Classification == answer.Classification ? ComparisonResult.Correct : ComparisonResult.Incorrect,
                ClassificationValue = guess.Classification.GetDisplayName(),

                CombatStyle = guess.CombatStyle == answer.CombatStyle ? ComparisonResult.Correct : ComparisonResult.Incorrect,
                CombatStyleValue = guess.CombatStyle.GetDisplayName(),

                DebutYear = guess.DebutYear == answer.DebutYear ? ComparisonResult.Correct : ComparisonResult.Incorrect,
                DebutYearValue = guess.DebutYear,
                DebutYearArrow = guess.DebutYear < answer.DebutYear ? "⬆️" : (guess.DebutYear > answer.DebutYear ? "⬇️" : "")
            };

            var commonAffiliations = guess.Affiliations.Intersect(answer.Affiliations).Count();
            if (commonAffiliations == answer.Affiliations.Count && guess.Affiliations.Count == answer.Affiliations.Count)
            {
                result.Affiliations = ComparisonResult.Correct;
            }
            else if (commonAffiliations > 0)
            {
                result.Affiliations = ComparisonResult.Partial;
            }
            else
            {
                result.Affiliations = ComparisonResult.Incorrect;
            }
            result.AffiliationsValue = string.Join(", ", guess.Affiliations);

            return result;
        }

        private List<GuessResultViewModel> GetGuessesFromSession()
        {
            var guessesJson = HttpContext.Session.GetString(SessionKeyGuesses);
            return guessesJson == null ? new List<GuessResultViewModel>() : JsonSerializer.Deserialize<List<GuessResultViewModel>>(guessesJson);
        }

        private void CheckForNewDay()
        {
            var lastVisitDate = HttpContext.Session.GetString("_LastVisitDate");
            var today = DateTime.Now.ToShortDateString();
            if (lastVisitDate != today)
            {
                HttpContext.Session.Clear();
                HttpContext.Session.SetString("_LastVisitDate", today);
            }
        }
    }
}