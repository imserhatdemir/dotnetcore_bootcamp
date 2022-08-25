using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Bootcamp.Controllers
{
    [AllowAnonymous]
    public class Errorpage : Controller
    {
        public IActionResult Error1(int code)
        {

            return View();
        }
    }
}
