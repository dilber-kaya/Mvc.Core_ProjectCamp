using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryServiceBL
    {
        void AddCategoryBL(Category category);
        void DeleteCategoryBL(Category category);
        void UpdateCategoryBL(Category category);
        List<Category> ListCategoryBL();
        Category GetByIdCategoryBL(int id);

    }
}
