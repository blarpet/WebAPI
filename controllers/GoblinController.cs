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
        private static List<Post> posts = new List<Post>
        {
            new Post(),
            new Post {Id = 1, Date = 21032022, Title = "I HATE goblin grease", Bodytext = "Goblin grease sucks big time!!1! and only those 1%er goblins wear them, they're trying to control you fellow goblins dont follow their propaganda and watch out for glowgobs!!!" }
        };
        [HttpGet]
        public ActionResult<List<Post>> Get()
        {
            return Ok(posts);
        }

        [HttpGet("{id}")]   
        public ActionResult<Post> GetSingle(int id)
        {
            return Ok(posts.FirstOrDefault(g => g.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Post>> AddPost(Post newPost)
        {
            posts.Add(newPost);
            return Ok(posts);
            
        }
    }
}