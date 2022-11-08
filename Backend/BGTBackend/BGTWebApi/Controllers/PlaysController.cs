using Microsoft.AspNetCore.Mvc;
using BGTWebApi.Models.Plays;
using BGTWebApi.Models.Players;

namespace BGTWebApi.Controllers
{

    public class PlaysController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<PlaysListVm>> GetPlaysList()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<PlayDetailsVm>> GetPlayDetails()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreatePlay(CreatePlayDto createDto)
        {
            return Ok(Guid.NewGuid());
        }

        [HttpPut]
        public async Task<ActionResult> UpdatePlay(UpdatePlayerDto updateDto)
        {
            return Ok();
        }
    }
}
