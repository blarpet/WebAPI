using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.models;
using WEBAPI.Services.PostServices;

namespace WEBAPI.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoblinController : ControllerBase
    {
        private readonly IPostService _postService;
        public GoblinController(IPostService _postService)
        {
            _postService = postService;
        }
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