

using System.Collections.Generic;
using Dotnet_RPG.Models;

namespace Dotnet_RPG.Services.CharacterService

{
    public interface ICharacterServices
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById();
        List<Character> AddCharacter(Character NewCharacter);
    }
}