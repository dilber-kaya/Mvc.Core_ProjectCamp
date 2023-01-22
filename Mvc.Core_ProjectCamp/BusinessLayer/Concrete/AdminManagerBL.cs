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
    public class AdminManagerBL:IAdminServiceBL
    {
        IAdminDAL adminDAL;

        public AdminManagerBL(IAdminDAL adminDAL)
        {
            this.adminDAL = adminDAL;
        }

        public Admin GetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> ListBL()
        {
            throw new NotImplementedException();
        }

        public void TAddBL(Admin t)
        {
            throw new NotImplementedException();
        }

        public void TDeleteBL(Admin t)
        {
            throw new NotImplementedException();
        }

        public void TUpdateBL(Admin t)
        {
            throw new NotImplementedException();
        }
    }
}
