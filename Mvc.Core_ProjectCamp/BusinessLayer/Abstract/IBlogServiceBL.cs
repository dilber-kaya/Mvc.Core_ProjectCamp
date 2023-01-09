using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogServiceBL
	{
		void AddBlogBL(Blog blog);
		void DeleteBlogBL(Blog blog);
		void UpdateBlogBL(Blog blog);
		List<Blog> ListBlogBL();
		Blog GetByIdBlogBL(int id);
		List<Blog> GetBlogListWithCategoryBL();
		List<Blog> GetBlogListWithWriterBL(int id);

	}
}
