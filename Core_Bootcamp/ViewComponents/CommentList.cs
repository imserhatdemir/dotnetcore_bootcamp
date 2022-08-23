using Core_Bootcamp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Bootcamp.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserName="Serhat"
                },
                new UserComment
                {
                    ID=2,
                    UserName="Murat"
                },new UserComment
                {
                    ID=3,
                    UserName="Vedat"
                },new UserComment
                {
                    ID=4,
                    UserName="Deneme"
                }

            };
            return View(commentvalues);
        }
    }
}
