using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManagerBL : IBlogServiceBL
	{
		IBlogDAL _blogDAL;

		public BlogManagerBL(IBlogDAL blogDAL)
		{
			_blogDAL = blogDAL;
		}

		public void AddBlogBL(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void DeleteBlogBL(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListWithCategoryBL()
		{
			return _blogDAL.GetListWithCategoryDAL();
		}

		public Blog GetByIdBlogBL(int id)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogByIdFilterBL(int id)
		{
			return _blogDAL.ListDAL(x=>x.BlogID == id);
		}

		public List<Blog> ListBlogBL()
		{
			return _blogDAL.GetListAllDAL();
		}

		public void UpdateBlogBL(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListWithWriterBL(int id)
		{
			return _blogDAL.ListDAL(x => x.WriterID == id);
		}
	}
}
