using Microsoft.AspNetCore.Mvc;
using Dotnet_RPG.Models;
using System.Collections.Generic;

namespace Dotnet_RPG.Controllers


{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>()
        {
            new Character(),
            new Character{
            Name = "Mark",
            HitPoints = 150,
            Strength = 20,
            Defense = 20,
            Intelligence = 5,
        Class = RPGClass.Knight
    }

    };



        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult<Character> GetSingle()
        {

            return Ok(characters[0]);
        }    

    }
}
