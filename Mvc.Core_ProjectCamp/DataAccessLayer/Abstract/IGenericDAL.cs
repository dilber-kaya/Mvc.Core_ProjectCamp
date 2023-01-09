using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void InsertDAL (T t);
        void DeleteDAL (T t);
        void UpdateDAL (T t);
        List<T> GetListAllDAL();
        T GetByIdDAL(int id);
        List<T> ListDAL(Expression<Func<T, bool>> filter);
    }
}
