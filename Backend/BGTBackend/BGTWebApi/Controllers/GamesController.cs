using Microsoft.AspNetCore.Mvc;
using BGTWebApi.Models.Games;

namespace BGTWebApi.Controllers
{

    public class GamesController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<GameListVm>> GetGamesList()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<GameDetailsVm>> GetGameDetails(Guid gameId)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateGame(CreateGameDto createDto)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateGame(UpdateGameDto updateDto)
        {
            return Ok();
        }
    }
}
