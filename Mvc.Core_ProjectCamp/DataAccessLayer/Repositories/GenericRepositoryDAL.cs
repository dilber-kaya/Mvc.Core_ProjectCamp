using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepositoryDAL<T> : IGenericDAL<T> where T : class
    {
        public void DeleteDAL(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByIdDAL(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAllDAL()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void InsertDAL(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void UpdateDAL(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
