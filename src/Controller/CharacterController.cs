using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rpgAPI.src.Model;
using rpgAPI.src.Service;


namespace rpgAPI.src.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet]
        public ActionResult<ServiceResponse<List<Character>>> GetCharacter()
        {
            return Ok(_characterService.GetAllCharacter());
        }


        [HttpGet("id")]
        public ActionResult<ServiceResponse<Character>> GetId(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<ServiceResponse<List<Character>>> PostCharacter(Character newCharacter)
        {
            return Ok(_characterService.AddCharacter(newCharacter));
        }

        [HttpDelete]
        public ActionResult<ServiceResponse<Character>> DeleteCharacter(int id)
        {
            return Ok(_characterService.DeleteCharacter(id));
        }

        [HttpPut]
        public ActionResult<ServiceResponse<List<Character>>> UpdateCharacter(Character character)
        {
            return Ok(_characterService.UpdateCharacter(character));
        }
    }
}