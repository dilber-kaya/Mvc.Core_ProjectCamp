using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepositoryDAL : ICategoryDAL
    {
        Context c = new Context();
        public void AddCategoryDAL(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public void DeleteCategoryDAL(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public Category GetByIdCategoryDAL(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> ListCategoryDAL()
        {
            return c.Categories.ToList();
        }

        public void UpdateCategoryDAL(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
