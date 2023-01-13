using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EFBlogRepository : GenericRepositoryDAL<Blog>, IBlogDAL
	{
        public List<Blog> GetListWithCategoryByWriterDAL(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Where(x=>x.WriterID==id).ToList();
            }
        }

        public List<Blog> GetListWithCategoryDAL()
		{
			using (var c = new Context())
			{
				return c.Blogs.Include(x => x.Category).ToList();
			} 
		}
	}
}
