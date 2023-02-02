using Core.Contracts.Models;
using Core.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Presentation.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IConverterService _converterService;

        public PersonController(IConverterService converterService) 
        {
            _converterService = converterService;
        }

        [HttpGet("person")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CharacterModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorDetails))]
        public async Task<IActionResult> GetByName([FromQuery] string name)
        {
            var characters = await _converterService.GetCharactersByName(name);

            return Ok(characters);
        }

        [HttpPost("check-person")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorDetails))]
        public async Task<IActionResult> CheckPersonInEpisode([FromBody] PresenceRequest model)
        {
            throw new NotImplementedException();
            //var result = await _converterService.GetCharactersByName(name);

            //return Ok(result);
        }
    }
}
