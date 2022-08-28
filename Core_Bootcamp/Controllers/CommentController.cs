using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Bootcamp.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EFCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddComment(Comment p)
        {
            //ViewBag.id = p.BlogID;
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogID= 1;
            cm.AddComment(p);
            return PartialView();
        }
        public PartialViewResult CommentList(int id)
        {
           var values= cm.GetList(id);
            return PartialView(values);
        }
    }
}
