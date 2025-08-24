// Local: Services/LocalCharacterService.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JujutsuDle.Models;

public class LocalCharacterService : ICharacterService
{
    private readonly List<Character> _allCharacters;

    public LocalCharacterService()
    {
        _allCharacters = new List<Character>
    {
        // --- Alunos de Tóquio ---
        new Character { Id = 1, Name = "Yuji Itadori", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.CorpoACorpo, DebutYear = 2018, PhotoUrl = "https://files.shapes.inc/api/files/avatar_b1684a84-7ccb-4333-bfee-0d8d75b3711d.png" },
        new Character { Id = 2, Name = "Megumi Fushiguro", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio", "Clã Zen'in"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.Shikigami, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 3, Name = "Nobara Kugisaki", Gender = Gender.Feminino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 4, Name = "Maki Zen'in", Gender = Gender.Feminino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio", "Clã Zen'in"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.ArmaAmaldiçoada, DebutYear = 2017, PhotoUrl = "" },
        new Character { Id = 5, Name = "Toge Inumaki", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2017, PhotoUrl = "" },
        new Character { Id = 6, Name = "Panda", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio"}, Species = Species.CorpoAmaldiçoado, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.CorpoACorpo, DebutYear = 2017, PhotoUrl = "" },
        new Character { Id = 7, Name = "Yuta Okkotsu", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2017, PhotoUrl = "" },
        new Character { Id = 8, Name = "Kinji Hakari", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2021, PhotoUrl = "" },
        new Character { Id = 9, Name = "Kirara Hoshi", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2021, PhotoUrl = "" },

        // --- Alunos de Quioto ---
        new Character { Id = 10, Name = "Aoi Todo", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Quioto"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 11, Name = "Mai Zenin", Gender = Gender.Feminino, Affiliations = new List<string>{"Escola Jujutsu de Quioto", "Clã Zen'in"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.ArmaAmaldiçoada, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 12, Name = "Noritoshi Kamo", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Quioto", "Clã Kamo"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 13, Name = "Kasumi Miwa", Gender = Gender.Feminino, Affiliations = new List<string>{"Escola Jujutsu de Quioto"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.ArmaAmaldiçoada, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 14, Name = "Momo Nishimiya", Gender = Gender.Feminino, Affiliations = new List<string>{"Escola Jujutsu de Quioto"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 15, Name = "Kokichi Muta", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Quioto"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2018, PhotoUrl = "" },
        
        // --- Feiticeiros Profissionais ---
        new Character { Id = 16, Name = "Satoru Gojo", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2017, PhotoUrl = "" },
        new Character { Id = 17, Name = "Kento Nanami", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.ArmaAmaldiçoada, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 18, Name = "Mei Mei", Gender = Gender.Feminino, Affiliations = new List<string>{"Nenhuma"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.ArmaAmaldiçoada, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 19, Name = "Utahime Iori", Gender = Gender.Feminino, Affiliations = new List<string>{"Escola Jujutsu de Quioto", "Escola Jujutsu de Tóquio"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 20, Name = "Takuma Ino", Gender = Gender.Masculino, Affiliations = new List<string>{"Grupo do Nanami"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2020, PhotoUrl = "" },
        new Character { Id = 21, Name = "Shoko Ieiri", Gender = Gender.Feminino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 22, Name = "Masamichi Yaga", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.CorpoACorpo, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 23, Name = "Yoshinobu Gakuganji", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Quioto"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 24, Name = "Yuki Tsukumo", Gender = Gender.Feminino, Affiliations = new List<string>{"Nenhuma"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.Shikigami, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 25, Name = "Atsuya Kusakabe", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.ArmaAmaldiçoada, DebutYear = 2020, PhotoUrl = "" },

        // --- Antagonistas, Maldições e Outros ---
        new Character { Id = 26, Name = "Sukuna", Gender = Gender.Masculino, Affiliations = new List<string>{"Nenhuma"}, Species = Species.Maldição, Classification = Classification.MestreDeMaldição, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 27, Name = "Mahito", Gender = Gender.Masculino, Affiliations = new List<string>{"Grupo do Kenjaku"}, Species = Species.Maldição, Classification = Classification.MestreDeMaldição, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 28, Name = "Jogo", Gender = Gender.Masculino, Affiliations = new List<string>{"Grupo do Kenjaku"}, Species = Species.Maldição, Classification = Classification.MestreDeMaldição, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 29, Name = "Hanami", Gender = Gender.Masculino, Affiliations = new List<string>{"Grupo do Kenjaku"}, Species = Species.Maldição, Classification = Classification.MestreDeMaldição, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 30, Name = "Dagon", Gender = Gender.Masculino, Affiliations = new List<string>{"Grupo do Kenjaku"}, Species = Species.Maldição, Classification = Classification.MestreDeMaldição, CombatStyle = CombatStyle.Shikigami, DebutYear = 2020, PhotoUrl = "" },
        new Character { Id = 31, Name = "Choso", Gender = Gender.Masculino, Affiliations = new List<string>{"Irmãos Amaldiçoados"}, Species = Species.Híbrido, Classification = Classification.MestreDeMaldição, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2019, PhotoUrl = "" },
        new Character { Id = 32, Name = "Eso", Gender = Gender.Masculino, Affiliations = new List<string>{"Irmãos Amaldiçoados"}, Species = Species.Híbrido, Classification = Classification.MestreDeMaldição, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2019, PhotoUrl = "" },
        new Character { Id = 33, Name = "Kechizu", Gender = Gender.Masculino, Affiliations = new List<string>{"Irmãos Amaldiçoados"}, Species = Species.Híbrido, Classification = Classification.MestreDeMaldição, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2019, PhotoUrl = "" },
        new Character { Id = 34, Name = "Suguru Geto", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio", "Grupo do Kenjaku"}, Species = Species.Humano, Classification = Classification.UsuárioDeMaldição, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2017, PhotoUrl = "" },
        new Character { Id = 35, Name = "Kenjaku", Gender = Gender.Masculino, Affiliations = new List<string>{"Grupo do Kenjaku"}, Species = Species.Humano, Classification = Classification.UsuárioDeMaldição, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2017, PhotoUrl = "" },
        new Character { Id = 36, Name = "Uraume", Gender = Gender.Outro, Affiliations = new List<string>{"Grupo do Kenjaku"}, Species = Species.Humano, Classification = Classification.UsuárioDeMaldição, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2020, PhotoUrl = "" },
        new Character { Id = 37, Name = "Toji Fushiguro", Gender = Gender.Masculino, Affiliations = new List<string>{"Clã Zen'in"}, Species = Species.Humano, Classification = Classification.Civil, CombatStyle = CombatStyle.ArmaAmaldiçoada, DebutYear = 2019, PhotoUrl = "" },
        new Character { Id = 38, Name = "Naoya Zenin", Gender = Gender.Masculino, Affiliations = new List<string>{"Clã Zen'in"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2021, PhotoUrl = "" },
        new Character { Id = 39, Name = "Naobito Zenin", Gender = Gender.Masculino, Affiliations = new List<string>{"Clã Zen'in"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2020, PhotoUrl = "" },
        new Character { Id = 40, Name = "Junpei Yoshino", Gender = Gender.Masculino, Affiliations = new List<string>{"Nenhuma"}, Species = Species.Humano, Classification = Classification.UsuárioDeMaldição, CombatStyle = CombatStyle.Shikigami, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 41, Name = "Haruta Shigemo", Gender = Gender.Masculino, Affiliations = new List<string>{"Grupo do Kenjaku"}, Species = Species.Humano, Classification = Classification.UsuárioDeMaldição, CombatStyle = CombatStyle.ArmaAmaldiçoada, DebutYear = 2020, PhotoUrl = "" },
        new Character { Id = 42, Name = "Hana Kurusu", Gender = Gender.Feminino, Affiliations = new List<string>{"Nenhuma"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2021, PhotoUrl = "" },
        new Character { Id = 43, Name = "Hiromi Higuruma", Gender = Gender.Masculino, Affiliations = new List<string>{"Nenhuma"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2021, PhotoUrl = "" },
        new Character { Id = 44, Name = "Hajime Kashimo", Gender = Gender.Masculino, Affiliations = new List<string>{"Nenhuma"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2021, PhotoUrl = "" },
        new Character { Id = 45, Name = "Yorozu", Gender = Gender.Feminino, Affiliations = new List<string>{"Nenhuma"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2022, PhotoUrl = "" },
        new Character { Id = 46, Name = "Fumihiko Takaba", Gender = Gender.Masculino, Affiliations = new List<string>{"Nenhuma"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2021, PhotoUrl = "" },
        new Character { Id = 47, Name = "Rika Orimoto", Gender = Gender.Feminino, Affiliations = new List<string>{"Nenhuma"}, Species = Species.Maldição, Classification = Classification.MestreDeMaldição, CombatStyle = CombatStyle.CorpoACorpo, DebutYear = 2017, PhotoUrl = "" },
        new Character { Id = 48, Name = "Takako Uro", Gender = Gender.Feminino, Affiliations = new List<string>{"Esquadrão de Assassinos"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2022, PhotoUrl = "" },
        new Character { Id = 49, Name = "Ryu Ishigori", Gender = Gender.Masculino, Affiliations = new List<string>{"Nenhuma"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2022, PhotoUrl = "" },
        new Character { Id = 50, Name = "Miguel", Gender = Gender.Masculino, Affiliations = new List<string>{"Grupo do Geto"}, Species = Species.Humano, Classification = Classification.UsuárioDeMaldição, CombatStyle = CombatStyle.CorpoACorpo, DebutYear = 2017, PhotoUrl = "" },
        new Character { Id = 51, Name = "Yu Haibara", Gender = Gender.Masculino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.CorpoACorpo, DebutYear = 2018, PhotoUrl = "" },
        new Character { Id = 52, Name = "Mimiko Hasaba", Gender = Gender.Feminino, Affiliations = new List<string>{"Grupo do Geto"}, Species = Species.Humano, Classification = Classification.UsuárioDeMaldição, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2017, PhotoUrl = "" },
        new Character { Id = 53, Name = "Nanako Hasaba", Gender = Gender.Feminino, Affiliations = new List<string>{"Grupo do Geto"}, Species = Species.Humano, Classification = Classification.UsuárioDeMaldição, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2017, PhotoUrl = "" },
        new Character { Id = 54, Name = "Tengen", Gender = Gender.Feminino, Affiliations = new List<string>{"Escola Jujutsu de Tóquio"}, Species = Species.Humano, Classification = Classification.Feiticeiro, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2019, PhotoUrl = "" },
        new Character { Id = 55, Name = "Tsumiki Fushiguro", Gender = Gender.Feminino, Affiliations = new List<string>{"Nenhuma"}, Species = Species.Humano, Classification = Classification.Civil, CombatStyle = CombatStyle.TécnicaInata, DebutYear = 2019, PhotoUrl = "" }
    };
}
    

    public Task<Character> GetCharacterOfTheDayAsync()
    {
        var dayIndex = DateTime.Now.DayOfYear % _allCharacters.Count;
        return Task.FromResult(_allCharacters[dayIndex]);
    }

    public Task<Character> FindCharacterByNameAsync(string name)
    {
        var character = _allCharacters.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        return Task.FromResult(character);
    }
    
    public Task<List<string>> GetAllCharacterNamesAsync()
    {
        var names = _allCharacters.Select(c => c.Name).OrderBy(name => name).ToList();
        return Task.FromResult(names);
    }


    public Task<Character> GetRandomCharacterAsync()
    {
        var random = new Random();
        var randomIndex = random.Next(0, _allCharacters.Count);
        var character = _allCharacters[randomIndex];
        return Task.FromResult(character);
    }

    public Task<Character> GetCharacterByIdAsync(int id)
    {
        var character = _allCharacters.FirstOrDefault(c => c.Id == id);
        return Task.FromResult(character);
    }
}