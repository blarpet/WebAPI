using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.models;
using WEBAPI.Services.PostServices;

namespace WEBAPI.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        [HttpGet]
        public ActionResult<List<Post>> GetPost()
        {
            return Ok(_postService.GetPostList());
        }
        [HttpPost]
        public ActionResult<List<Post>> AddPost(Post newPost)
        {
            return Ok(_postService.AddPost(newPost));
        }
        [HttpDelete]
        public ActionResult<List<Post>> DeletePost(int id)
        {
            return Ok(_postService.DeletePost(id));
        }
        [HttpPut]
        public ActionResult<List<Post>> UpdatePost(Post UpdatePost)
        {
            return Ok(_postService.UpdatePost(UpdatePost));
        }
    }
}