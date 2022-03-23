using System.Collections.Generic;
using WEBAPI.models;

namespace WEBAPI.Services.PostServices
{
    public interface IPostService
    {
        List<Post> GetPostList();
        List<Post> AddPost(Post newPost);
        List<Post> DeletePost(int id);
         List<Post> UpdatePost(Post updatePost);
    }
}