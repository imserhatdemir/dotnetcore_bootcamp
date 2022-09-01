using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Bootcamp.ViewComponents.Writer
{
    public class WriterAbountOnDashboard : ViewComponent
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());

        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            var writerID = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var value = wm.GetAboutByWriter(writerID);
            return View(value);
        }
    }
}
