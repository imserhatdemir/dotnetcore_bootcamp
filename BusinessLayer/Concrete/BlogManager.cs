﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDAL _blogDAL;

        public BlogManager(IBlogDAL blogDAL)
        {
            _blogDAL = blogDAL;
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDAL.GetListWithCategory();
        }

        public Blog GetByID(int id)
        {
            return _blogDAL.GetByID(id);
        }

        public List<Blog> GetBlogByID(int id)
        {
            return _blogDAL.GetListAll(x => x.BlogID == id);
        }
        public List<Blog> GetList()
        {
            return _blogDAL.GetList();
        }


        public List<Blog> GetLast3Blog()
        {
            return _blogDAL.GetList().Take(3).ToList();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDAL.GetListAll(x => x.WriterID == id);
        }

        public void TAdd(Blog t)
        {
            _blogDAL.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDAL.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDAL.Update(t);
        }

        public List<Blog> GetListByCtgandwriter(int id)
        {
            return _blogDAL.GetListWithCategoryByWriter(id);
        }
    }
}
