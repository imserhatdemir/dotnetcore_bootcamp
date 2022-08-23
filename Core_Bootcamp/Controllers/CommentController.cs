using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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

        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        public PartialViewResult CommentList(int id)
        {
           var values= cm.GetList(id);
            return PartialView(values);
        }
    }
}
