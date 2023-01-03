using BusinessLayer.Abstract;
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
        EFCategoryRepository efCategoryRepository;

        public CategoryManagerBL()
        {
            efCategoryRepository = new EFCategoryRepository();
        }

        public void AddCategoryBL(Category category)
        {
            efCategoryRepository.InsertDAL(category);

        }

        public void DeleteCategoryBL(Category category)
        {
            efCategoryRepository.DeleteDAL(category);
        }

        public Category GetByIdCategoryBL(int id)
        {
            return efCategoryRepository.GetByIdDAL(id);
        }

        public List<Category> ListCategoryBL()
        {
            return efCategoryRepository.GetListAllDAL();
        }

        public void UpdateCategoryBL(Category category)
        {
            efCategoryRepository.UpdateDAL(category);
        }
    }
}
