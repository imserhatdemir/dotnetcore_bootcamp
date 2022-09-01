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
    public class AdminManager : IAdminService
    {
        IAdminDAL _adminDAL;

        public AdminManager(IAdminDAL adminDAL)
        {
            _adminDAL = adminDAL;
        }

        public Admin GetByID(int id)
        {
            return _adminDAL.GetByID(id);
        }

        public List<Admin> GetList()
        {
            return _adminDAL.GetList();
        }

        public void TAdd(Admin t)
        {
            _adminDAL.Insert(t);
        }

        public void TDelete(Admin t)
        {
            _adminDAL.Delete(t);
        }

        public void TUpdate(Admin t)
        {
            _adminDAL.Update(t);
        }
    }
}
