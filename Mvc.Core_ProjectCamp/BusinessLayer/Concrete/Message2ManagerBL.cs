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
    public class Message2ManagerBL : IMessage2ServiceBL
    {
        IMessage2DAL _messageDAL;

        public Message2ManagerBL(IMessage2DAL messageDAL)
        {
            _messageDAL = messageDAL;
        }

        public Message2 GetByIdBL(int id)
        {
            return _messageDAL.GetByIdDAL(id);
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _messageDAL.GetListWithMessageByWriterDAL(id);
        }

        public List<Message2> ListBL()
        {
            return _messageDAL.GetListAllDAL();
        }

        public void TAddBL(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TDeleteBL(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TUpdateBL(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
