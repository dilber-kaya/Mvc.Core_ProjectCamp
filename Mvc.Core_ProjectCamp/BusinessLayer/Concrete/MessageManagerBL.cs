using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManagerBL : IMessageServiceBL
    {
        IMessageDAL _messageDAL;

        public MessageManagerBL(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }

        public Message GetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messageDAL.ListDAL(x => x.Receiver == p);
        }

        public List<Message> ListBL()
        {
            return _messageDAL.GetListAllDAL();
        }

        public void TAddBL(Message t)
        {
            throw new NotImplementedException();
        }

        public void TDeleteBL(Message t)
        {
            throw new NotImplementedException();
        }

        public void TUpdateBL(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
