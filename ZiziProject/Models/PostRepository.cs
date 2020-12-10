using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZiziProject.Models
{
    public class PostRepository : IPostRepo
    {
        List<Post> posts = new List<Post>();
        public void AddPost(Post post)
        {
            posts.Add(post);
          
        }

        public List<Post> GetAllPosts()
        {
            return posts;
       
        }

        public List<Post> GetByUser(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        //public List<Post> GetByUser(IdentityUser user)
        //{
        //    throw new NotImplementedException();
        //}

        public Post GetPost(int id)
        {
            Post temp = posts.FirstOrDefault(i => i.id == id);
            return temp;
           
        }

        public void RemovePost(int id)
        {
            Post temp = posts.FirstOrDefault(i => i.id == id);
            posts.Remove(temp);
            
        }

        void IPostRepo.UpdatePost(int id, Post post)
        {
            throw new NotImplementedException();
        }

        //public void UpdatePost(int id, Post post)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
