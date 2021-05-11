using Microsoft.AspNetCore.Mvc;
using Dotnet_RPG.Models;
using Dotnet_RPG.DTOs;
using System.Collections.Generic;
using System.Linq;
using Dotnet_RPG.Services.CharacterService;
using System.Threading.Tasks;

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
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> Get()
        {
            return Ok(await _characterServices.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDTO>>> GetSingle(int id)
        {
            return Ok(await _characterServices.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> AddCharacter(AddCharacterDTO newCharacter)
        {
            await _characterServices.AddCharacter(newCharacter);
            return Ok(await _characterServices.GetAllCharacters());
        }

    }
}
