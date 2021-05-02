

using System.Collections.Generic;
using Dotnet_RPG.Models;
using System.Threading.Tasks;

namespace Dotnet_RPG.Services.CharacterService

{
    public interface ICharacterServices
    {
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character NewCharacter);
    }
}