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
    public class WriterManager : IWriterService
    {
        IWriterDAL _writerDAL;

        public WriterManager(IWriterDAL writerDAL)
        {
            this._writerDAL = writerDAL;
        }

        public List<Writer> GetAboutByWriter(int id)
        {
            return _writerDAL.GetListAll(x => x.WriterID == id); 
        }

        public Writer GetByID(int id)
        {
           return _writerDAL.GetByID(id);
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Writer t)
        {
            _writerDAL.Insert(t);
        }

        public void TDelete(Writer t)
        {
            _writerDAL.Delete(t);
        }

        public void TUpdate(Writer t)
        {
            _writerDAL.Update(t);
        }
    }
}
