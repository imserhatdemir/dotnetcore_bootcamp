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
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EFNewsLetterRepository());

        [HttpGet]
        public PartialViewResult Subscribe()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult Subscribe(NewsLetter p)
        {
            p.MailStatus = true;
            nm.AddMail(p);
            return PartialView();
        }
    }
}
