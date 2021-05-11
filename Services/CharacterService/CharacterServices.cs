using System.Collections.Generic;
using Dotnet_RPG.Models;
using System.Linq;
using System.Threading.Tasks;
using Dotnet_RPG.DTOs;

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


        public async Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return serviceResponse;

        }

        public async Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            serviceResponse.Data = characters.FirstOrDefault(c => c.Id == id);
            return serviceResponse;
        }
    }
}