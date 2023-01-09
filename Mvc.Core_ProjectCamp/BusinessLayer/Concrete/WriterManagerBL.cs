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

		public void AddWriterBL(Writer writer)
		{
			_writerDAL.InsertDAL(writer);
		}
	}
}
