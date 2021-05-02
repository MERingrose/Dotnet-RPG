using Microsoft.AspNetCore.Mvc;
using Dotnet_RPG.Models;
using System.Collections.Generic;
using System.Linq;
using Dotnet_RPG.Services.CharacterService;

namespace Dotnet_RPG.Controllers


{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterServices _characterServices;

        public CharacterController(ICharacterServices characterServices)
        {
            _characterServices = characterServices;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Character>>> Get()
        {
            return Ok(await _characterServices.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetSingle(int id)
        {
            return Ok(await _characterServices.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter)
        {
            _characterServices.AddCharacter(newCharacter);
            return Ok(await _characterServices.GetAllCharacters());
        }

    }
}
