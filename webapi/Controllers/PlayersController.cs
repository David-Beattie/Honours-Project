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

        [HttpGet]
        public string Get()
        {
            dbContext db = new dbContext();
            IList<Player> Players = db.Players.ToList();
            //convert list to json string
            string JSON = JsonConvert.SerializeObject(Players);
            return JSON;

       }

        
    
    }

    }
