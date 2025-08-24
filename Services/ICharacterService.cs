using System.Collections.Generic;
using System.Threading.Tasks; 
using JujutsuDle.Models;

public interface ICharacterService
{
    Task<Character> GetCharacterOfTheDayAsync();
    Task<Character> FindCharacterByNameAsync(string name);
    Task<List<string>> GetAllCharacterNamesAsync();
    Task<Character> GetRandomCharacterAsync();
    Task<Character> GetCharacterByIdAsync(int id);
}