using Microsoft.AspNetCore.Mvc;
using BGTWebApi.Models.Players;

namespace BGTWebApi.Controllers
{

    public class PlayersController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<PlayersListVm>> GetPlayersList()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<PlayerDetailsVm>> GetPlayerDetails()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreatePlayer(CreatePlayerDto createPlayer)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeletePlayer(Guid playerId)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdatePlayer(UpdatePlayerDto updatePlayer)
        {
            return Ok();
        }
    }
}
