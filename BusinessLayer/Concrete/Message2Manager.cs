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
    public class Message2Manager : IMessage2Service
    {
        IMessage2DAL _message2DAL;

        public Message2Manager(IMessage2DAL message2DAL)
        {
            _message2DAL = message2DAL;
        }

        public Message2 GetByID(int id)
        {
            return _message2DAL.GetByID(id);
        }

        public List<Message2> GetInboxListByWriter(int p)
        {
            return _message2DAL.GetListWithMeesageByWriter(p);
        }

        public List<Message2> GetList()
        {
            return _message2DAL.GetList();
        }

        public void TAdd(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
