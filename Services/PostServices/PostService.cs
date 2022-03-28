using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WEBAPI.models;

namespace WEBAPI.Services.PostServices
{
    public class PostService : IPostService
    {
        private static List<Post> postList = new List<Post>()
        {
            new Post() {Id = 1, Date = 21032022, Title = "I HATE goblin grease", Bodytext = "Goblin grease sucks big time!!1! and only those 1%er goblins wear them, they're trying to control you fellow goblins dont follow their propaganda and watch out for glowgobs!!!" },
            new Post()
        };
        private readonly DataContext _context;

        public PostService(DataContext context)
        {
            _context = context;
        }

        public List<Post> GetPostList()
        {
            return _context.posts.ToList();
        }
        public List<Post> AddPost(Post newPost)
        {
            _context.posts.Add(newPost);
            _context.SaveChanges();
            return _context.posts.ToList();
        }
        public List<Post> DeletePost(int id) 
        {
            var foundPost = _context.posts.FirstOrDefault(post => post.Id == id);
            _context.posts.Remove(foundPost);
            _context.SaveChanges();
            return _context.posts.ToList();
        }

       

        public List<Post> UpdatePost (Post updatePost)
        {
            var foundPost = _context.posts.FirstOrDefault(post => post.Id == updatePost.Id);
            if(foundPost != null)
            {
                foundPost.Title = updatePost.Title;
                foundPost.Date = updatePost.Date;
            }
            _context.SaveChanges();
            return _context.posts.ToList();
        }

    }
}