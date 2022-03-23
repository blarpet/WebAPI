using System.Collections.Generic;
using System.Linq;
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

        public List<Post> GetPostList()
        {
            return postList;
        }
        public List<Post> AddPost(Post newPost)
        {
            postList.Add(newPost);
            return postList;
        }
        public List<Post> DeletePost(int id) 
        {
            var foundPost = postList.FirstOrDefault(post => post.Id == id);
            postList.Remove(foundPost);
            return postList;
        }

       

        public List<Post> UpdatePost (Post updatePost)
        {
            var foundPost = postList.FirstOrDefault(post => post.Id == updatePost.Id);
            if(foundPost != null)
            {
                foundPost.Title = updatePost.Title;
                foundPost.Date = updatePost.Date;
            }
            return postList;
        }

    }
}