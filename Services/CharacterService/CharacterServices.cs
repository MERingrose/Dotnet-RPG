using System.Collections.Generic;
using Dotnet_RPG.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_RPG.Services.CharacterService
{
    public class CharacterServices : ICharacterServices
    {
        private static List<Character> characters = new List<Character>()
        {
            new Character(),
            new Character{
            Id = 1,
            Name = "Mark",
            HitPoints = 150,
            Strength = 20,
            Defense = 20,
            Intelligence = 5,
            Class = RPGClass.Knight
            }
        };


        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;

        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}