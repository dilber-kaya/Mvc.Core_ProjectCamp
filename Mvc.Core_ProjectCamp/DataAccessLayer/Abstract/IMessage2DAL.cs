using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMessage2DAL : IGenericDAL<Message2>
    {
        List<Message2> GetInboxWithMessageByWriterDAL(int id);
        List<Message2> GetSendBoxWithMessageByWriterDAL(int id);
    }
}
