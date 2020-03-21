using System.Linq;
using GameWorldService.Domain.Logic;
using Microsoft.AspNetCore.Mvc;

namespace GameWorldService.Api.Controllers
{
    [Route("/api/v0/game")]
    public class GameController : Controller
    {
        private readonly IGameWorldService _gameService;

        public GameController(IGameWorldService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        [Route("world")]
        public JsonResult World(string nick)
        {
            var world = _gameService.GetField(nick.ToLower());
            return Json(world);
        }

        [HttpGet]
        [Route("users")]
        public JsonResult WorldUsers()
        {
            var users = _gameService.GetFields()
                .OrderBy(fld => fld.FieldOwner)
                .Select(fld => fld.FieldOwner);
            return Json(users);
        }
    }
}
