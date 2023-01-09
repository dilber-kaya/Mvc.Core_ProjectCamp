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

		public List<About> ListAboutBL()
		{
			return _aboutDAL.GetListAllDAL();
		}
	}
}
