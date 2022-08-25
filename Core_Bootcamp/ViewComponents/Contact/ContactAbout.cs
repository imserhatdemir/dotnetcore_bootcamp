using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Bootcamp.ViewComponents.Contact
{
    public class ContactAbout : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
