﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public Category GetByID(int id)
        {
            return _categoryDAL.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _categoryDAL.GetList();
        }

        public void TAdd(Category t)
        {
            _categoryDAL.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDAL.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDAL.Update(t);
        }
    }
}
