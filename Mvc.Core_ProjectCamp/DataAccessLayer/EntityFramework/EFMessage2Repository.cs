using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFMessage2Repository : GenericRepositoryDAL<Message2>, IMessage2DAL
    {
        public List<Message2> GetSendBoxWithMessageByWriterDAL(int id)
        {
            using (var c = new Context())
            {
                return c.Message2s.Include(x => x.ReceiverUser).Where(x => x.SenderID == id).ToList();
            }
        }

        public List<Message2> GetInboxWithMessageByWriterDAL(int id)
        {
            using (var c = new Context())
            {
                return c.Message2s.Include(x => x.SenderUser).Where(x => x.ReceiverID == id).ToList();
            }
        }

    }
}
