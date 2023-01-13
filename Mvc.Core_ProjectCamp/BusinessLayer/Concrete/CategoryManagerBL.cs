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
        public Category GetByIdBL(int id)
        {
            return _categoryDAL.GetByIdDAL(id);
        }
        public List<Category> ListBL()
        {
            return _categoryDAL.GetListAllDAL();
        }
        public void TAddBL(Category t)
        {
            _categoryDAL.InsertDAL(t);
        }
        public void TDeleteBL(Category t)
        {
            _categoryDAL.DeleteDAL(t);
        }
        public void TUpdateBL(Category t)
        {
            _categoryDAL.UpdateDAL(t);
        }
    }
}
