﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Bootcamp.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.admins.Where(x => x.AdminID == 1).Select(y => y.Name).FirstOrDefault();
            ViewBag.v2 = c.admins.Where(x => x.AdminID == 1).Select(y => y.Image).FirstOrDefault();
            ViewBag.v3 = c.admins.Where(x => x.AdminID == 1).Select(y => y.Description).FirstOrDefault();
            return View();
        }
    }
}
