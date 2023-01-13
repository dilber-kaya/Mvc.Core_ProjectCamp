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
	public class AboutManagerBL : IAboutServiceBL
	{
		IAboutDAL _aboutDAL;

		public AboutManagerBL(IAboutDAL aboutDAL)
		{
			_aboutDAL = aboutDAL;
		}

        public About GetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

  //      public List<About> ListAboutBL()
		//{
		//	return _aboutDAL.GetListAllDAL();
		//}

        public List<About> ListBL()
        {
            return _aboutDAL.GetListAllDAL();
        }

        public void TAddBL(About t)
        {
            throw new NotImplementedException();
        }

        public void TDeleteBL(About t)
        {
            throw new NotImplementedException();
        }

        public void TUpdateBL(About t)
        {
            throw new NotImplementedException();
        }
    }
}
