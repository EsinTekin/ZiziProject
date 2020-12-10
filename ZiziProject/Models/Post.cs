using Microsoft.AspNetCore.Identity;

namespace ZiziProject.Models
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public IdentityUser user { get; set; }
    }
}