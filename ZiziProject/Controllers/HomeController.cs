using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ZiziProject.Models;

namespace ZiziProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepo repo;



        public HomeController(IPostRepo postRepository)
        {
            repo = postRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        [HttpGet]
        public IActionResult Hikayemiz()
        {
            return View();
        }
        public IActionResult Eserler()
        {
            // repository nesnesinden bir örnek alıyoruz
           // PostRepository repo = new PostRepository();
            // bir post nesnesi oluşturuyoruz
            var obj = new Post
            {
                title = "İlk Blog Başlığı",
                content = "İlk blog içeriği"
            };
            // nesneyi kayıt ediyoruz
            repo.AddPost(obj);
            // ikinci bir post nesnesi oluşturuyoruz
            var obj2 = new Post
            {
                title = "İkinci Blog Başlığı",
                content = "İkinci blog içeriği"
            };
            // obj2 nesnesini kayıt ediyoruz
            repo.AddPost(obj2);

            var obj3 = new Post
            {
                title = "Üçüncü Blog Başlığı",
                content = "Üçüncü blog içeriği"
            };
            repo.AddPost(obj3);
            var obj4 = new Post
            {
                title = "4. Blog Başlığı",
                content = "4. blog içeriği"
            };
            repo.AddPost(obj4);
            var obj6 = new Post
            {
                title = "6. Blog Başlığı",
                content = "6. blog içeriği"
            };
            repo.AddPost(obj6);
            //ViewData["secilenNesne"] = obj6;
            //var obj5 = repo.GetPost(16);
            //ViewData["secilenNesne"] = obj5;
            // obj3 içerisine id'si 1 olan nesneyi atıyoruz
            //var obj3 = repo.GetPost(1);
            //// ViewData ile obj3 içindeki değeri html içerisinde çağırmak için kayıt ediyoruz
            //ViewData["secilenNesne"] = obj3;

            // View'e farklı veri tipleri geçerek cshtml içerisinde
            // ekrana basabiliriz
            return View(repo.GetAllPosts());
           // return View();
        }
        public IActionResult Iletisim()
        {
            return View();
        }

        [Authorize]
        public IActionResult Firsatlar()
        {
            return View();
        }
    }
}
