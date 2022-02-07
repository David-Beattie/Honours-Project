using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using honsProject.Shared; 
using Newtonsoft.Json;


namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<PlayersController> _logger;

        public PlayersController(ILogger<PlayersController> logger)
        {
            _logger = logger;
        }

//controller http get method to get the player names from players.db
        [HttpGet]
        public string Get()
        {
            //create an instance of the database context class
            dbContext db = new dbContext();
            //get a list of players from players.db
            IList<Player> Players = db.Players.ToList();
            //convert list to json string
            string JSON = JsonConvert.SerializeObject(Players);
            return JSON;

       }

        
    
    }

    }
