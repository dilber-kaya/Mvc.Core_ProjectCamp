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
	public class ContactManagerBL:IContactServiceBL
	{
		IContactDAL _contactDAL;

		public ContactManagerBL(IContactDAL contactDAL)
		{
			_contactDAL = contactDAL;
		}

		public void AddContactBL(Contact contact)
		{
			_contactDAL.InsertDAL(contact);
		}
	}
}
