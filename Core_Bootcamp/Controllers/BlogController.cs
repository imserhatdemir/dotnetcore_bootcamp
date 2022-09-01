using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataAccessLayer.Concrete;

namespace Core_Bootcamp.Controllers
{

    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        WriterManager wm = new WriterManager(new EFWriterRepository());

        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }


        public IActionResult BlogListByWriter()
        {
            Context c = new Context();
            var usermail = User.Identity.Name;
            var writerID = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var value = wm.GetAboutByWriter(writerID);
            var values=bm.GetListByCtgandwriter(writerID);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddBlog()
        {
            CategoryManager cm = new CategoryManager(new EFCategoryRepository());
            List<SelectListItem> categories = (from x in cm.GetList() select new SelectListItem {
                Text =x.CategoryName,
                Value=x.CategoryID.ToString()
              }).ToList();

            ViewBag.cv = categories;

            return View();
        }


        [HttpPost]
        public IActionResult AddBlog(Blog p)
        {
            Context c = new Context();
            var usermail = User.Identity.Name;
            var writerID = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var value = wm.GetAboutByWriter(writerID);
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = writerID;
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            var values = bm.GetByID(id);
            bm.TDelete(values);
            return RedirectToAction("BlogListByWriter");
        }


        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            CategoryManager cm = new CategoryManager(new EFCategoryRepository());
            List<SelectListItem> categories = (from x in cm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();

            ViewBag.cv = categories;
            var values = bm.GetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            Context c = new Context();
            var usermail = User.Identity.Name;
            var writerID = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var value = wm.GetAboutByWriter(writerID);
            p.WriterID = writerID;
            p.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.BlogStatus = true;
            bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter");
        }
        
    }
}
