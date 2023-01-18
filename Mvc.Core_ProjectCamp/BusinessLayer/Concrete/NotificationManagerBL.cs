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
    public class NotificationManagerBL : INotificationServiceBL
    {
        INotificationDAL _notificationDAL;

        public NotificationManagerBL(INotificationDAL notificationDAL)
        {
            _notificationDAL = notificationDAL;
        }

        public Notification GetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> ListBL()
        {
            return _notificationDAL.GetListAllDAL();
        }

        public void TAddBL(Notification t)
        {
            throw new NotImplementedException();
        }

        public void TDeleteBL(Notification t)
        {
            throw new NotImplementedException();
        }

        public void TUpdateBL(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
