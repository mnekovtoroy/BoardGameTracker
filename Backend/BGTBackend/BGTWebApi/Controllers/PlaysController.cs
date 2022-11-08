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
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeletePlay(Guid playId)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdatePlay(UpdatePlayerDto updateDto)
        {
            return Ok();
        }
    }
}
