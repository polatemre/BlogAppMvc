using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        //Blogcontextten bir örnek oluşturuldu.
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            //bütün bloglar gönderildi.
            return View(context.Bloglar.ToList());
        }
    }
}