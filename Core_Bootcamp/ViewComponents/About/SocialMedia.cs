using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Bootcamp.ViewComponents.About
{
    public class SocialMedia : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
