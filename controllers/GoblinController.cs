using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.models;

namespace WEBAPI.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoblinController : ControllerBase
    {
        private static List<Goblin> goblins = new List<Goblin>
        {
            new Goblin(),
            new Goblin {Name = "Ga'baol", Job = GoblinJob.Banker, Id = 1}
        };
        [HttpGet("{id}")]   
        public ActionResult<Goblin> GetSingle(int id)
        {
            return Ok(goblins.FirstOrDefault(g => g.Id == id));
        }
        [HttpPost]
        public ActionResult<List<Goblin>> AddGoblin(Goblin newGoblin)
        {
            goblins.Add(newGoblin);
            return Ok(goblins);
        }
        [HttpPost]
        public ActionResult<Post>
        {
            return Ok(Post);
        }
    }
}