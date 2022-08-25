using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDAL _ınewsletterdal;

        public NewsLetterManager(INewsLetterDAL ınewsletterdal)
        {
            _ınewsletterdal = ınewsletterdal;
        }

        public void AddMail(NewsLetter newsLetter)
        {
            _ınewsletterdal.Insert(newsLetter);
        }
    }
}
