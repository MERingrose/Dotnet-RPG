
using System.Collections.Generic;
using Dotnet_RPG.Models;
using System.Threading.Tasks;
using Dotnet_RPG.DTOs;

namespace Dotnet_RPG.Services.CharacterService

{
    public interface ICharacterServices
    {
        Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO NewCharacter);
    }
}