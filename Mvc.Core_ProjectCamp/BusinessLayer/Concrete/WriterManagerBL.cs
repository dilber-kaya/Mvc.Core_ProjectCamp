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
	public class WriterManagerBL:IWriterServiceBL
	{
		IWriterDAL _writerDAL;

		public WriterManagerBL(IWriterDAL writerDAL)
		{
			_writerDAL = writerDAL;
		}

        public Writer GetByIdBL(int id)
        {
            return _writerDAL.GetByIdDAL(id); 
        }

        public List<Writer> GetWriterByIdBL(int id)
        {
            return _writerDAL.ListDAL(x => x.WriterID == id);
        }

        public List<Writer> ListBL()
        {
            throw new NotImplementedException();
        }

        public void TAddBL(Writer t)
        {
            _writerDAL.InsertDAL(t);
        }

        public void TDeleteBL(Writer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdateBL(Writer t)
        {
            _writerDAL.UpdateDAL(t);
        }
    }
}
