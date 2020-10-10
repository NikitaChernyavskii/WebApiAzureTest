using System.Collections.Generic;
using System.Linq;
using AzureWebTestDb.Contexts;
using AzureWebTestDb.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AzureWebTestApi.Controllers
{
    [Route("players")]
    public class PlayerController : Controller
    {
        private readonly AzureWebTestAppTantiDbContext _azureWebTestAppTantiDbContext;

        public PlayerController(AzureWebTestAppTantiDbContext azureWebTestAppTantiDbContext)
        {
            _azureWebTestAppTantiDbContext = azureWebTestAppTantiDbContext;
        }

        [HttpGet]
        public List<Player> GetPlayers()
        {
            var players = _azureWebTestAppTantiDbContext.Players.ToList();

            return players;
        }

        [HttpGet("deleteme")]
        public List<Player> DELETE_ME()
        {
            var players = _azureWebTestAppTantiDbContext.Players.ToList();

            return players;
        }
    }
}
