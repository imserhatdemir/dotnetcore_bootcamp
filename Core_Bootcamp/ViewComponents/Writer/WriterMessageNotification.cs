﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Bootcamp.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        Message2Manager wm = new Message2Manager(new EFMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int id = 2;
            var values = wm.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
