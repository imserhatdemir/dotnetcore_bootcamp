using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Bootcamp.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.V1 = c.blogs.Count().ToString();
            ViewBag.V2 = c.blogs.Where(x => x.WriterID == 1).Count().ToString();
            ViewBag.V3 = c.categories.Count().ToString();
            return View();
        }
    }
}
