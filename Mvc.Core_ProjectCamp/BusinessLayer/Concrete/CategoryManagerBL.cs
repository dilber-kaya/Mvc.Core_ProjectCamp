using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManagerBL : ICategoryServiceBL
    {
        ICategoryDAL _categoryDAL;

        public CategoryManagerBL(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void AddCategoryBL(Category category)
        {
            _categoryDAL.InsertDAL(category);

        }

        public void DeleteCategoryBL(Category category)
        {
            _categoryDAL.DeleteDAL(category);
        }

        public Category GetByIdCategoryBL(int id)
        {
            return _categoryDAL.GetByIdDAL(id);
        }

        public List<Category> ListCategoryBL()
        {
            return _categoryDAL.GetListAllDAL();
        }

        public void UpdateCategoryBL(Category category)
        {
            _categoryDAL.UpdateDAL(category);
        }
    }
}
