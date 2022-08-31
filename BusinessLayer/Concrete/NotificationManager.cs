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
    public class NotificationManager : INotificationService
    {
        INotificationDAL _notificationDAL;

        public NotificationManager(INotificationDAL notificationDAL)
        {
            _notificationDAL = notificationDAL;
        }

        public Notification GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetList()
        {
         return _notificationDAL.GetList();
        }

        public void TAdd(Notification t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Notification t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
