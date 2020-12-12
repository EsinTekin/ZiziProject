using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZiziProject.Models
{
    public class PostRepository : IPostRepo
    {
        private readonly AppDbContext _appDbContext;
        // List<Post> posts = new List<Post>();
        public PostRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddPost(Post post)
        {
            _appDbContext.posts.Add(post);
            _appDbContext.SaveChanges();
            //posts.Add(post);
        }

        public List<Post> GetAllPosts()
        {
            return _appDbContext.posts.ToList<Post>();

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
            Post temp = _appDbContext.posts.FirstOrDefault(i => i.id == id);
            return temp;
           
        }

        public void RemovePost(int id)
        {
            Post temp = _appDbContext.posts.FirstOrDefault(i => i.id == id);
            _appDbContext.posts.Remove(temp);
            _appDbContext.SaveChanges();
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
