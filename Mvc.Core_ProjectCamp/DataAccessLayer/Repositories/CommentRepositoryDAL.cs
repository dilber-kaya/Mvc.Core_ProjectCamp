using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CommentRepositoryDAL : IGenericDAL<Comment>
    {
        public void DeleteDAL(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment GetByIdDAL(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListAllDAL()
        {
            throw new NotImplementedException();
        }

        public void InsertDAL(Comment t)
        {
            throw new NotImplementedException();
        }

        public void UpdateDAL(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
