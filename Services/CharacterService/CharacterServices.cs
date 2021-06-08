using System.Collections.Generic;
using Dotnet_RPG.Models;
using System.Linq;
using System.Threading.Tasks;
using Dotnet_RPG.DTOs.Character;
using AutoMapper;

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

        private readonly IMapper _mapper;

        public CharacterServices(IMapper mapper)
        {
            _mapper = mapper;
        }


        public async Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
            characters.Add(_mapper.Map<Character>(newCharacter));
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDTO>(c)).ToList();
            return serviceResponse;

        }

        public async Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDTO>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<GetCharacterDTO>();
            serviceResponse.Data = _mapper.Map<GetCharacterDTO>(characters.FirstOrDefault(c => c.Id == id));
            return serviceResponse;
        }
    }
}