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
    public class UserManagerBL : IUserServiceBL
    {
        IUserDAL _userDAL;

        public UserManagerBL(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }

        public AppUser GetByIdBL(int id)
        {
            return _userDAL.GetByIdDAL(id);
        }

        public List<AppUser> ListBL()
        {
            throw new NotImplementedException();
        }

        public void TAddBL(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TDeleteBL(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TUpdateBL(AppUser t)
        {
            _userDAL.UpdateDAL(t);
        }
    }
}
