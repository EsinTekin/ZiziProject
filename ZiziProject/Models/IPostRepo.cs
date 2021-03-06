﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZiziProject.Models
{
    public interface IPostRepo
    {
        void AddPost(Post post);
        Post GetPost(int id);
        List<Post> GetAllPosts();
        void RemovePost(int id);
        void UpdatePost(int id, Post post);
        List<Post> GetByUser(IdentityUser user);
    }
}
