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

		public List<Blog> GetBlogListWithCategoryBL()
		{
			return _blogDAL.GetListWithCategoryDAL();
		}
		public List<Blog> GetListWithCategoryByWriterBL(int id)
		{
			return _blogDAL.GetListWithCategoryByWriterDAL(id);
		}
        public List<Blog> GetBlogByIdFilterBL(int id)
		{
			return _blogDAL.ListDAL(x=>x.BlogID == id);
		}
		public List<Blog> GetLast3BlogBL()
		{
			return _blogDAL.GetListAllDAL().Take(3).ToList();
		}
		public List<Blog> GetBlogListWithWriterBL(int id)
		{
			return _blogDAL.ListDAL(x => x.WriterID == id);
		}

        public void TAddBL(Blog t)
        {
            _blogDAL.InsertDAL(t);
        }

        public void TDeleteBL(Blog t)
        {
            _blogDAL.DeleteDAL(t);
        }

        public void TUpdateBL(Blog t)
        {
            _blogDAL.UpdateDAL(t);
        }

        public List<Blog> ListBL()
        {
            return _blogDAL.GetListAllDAL();
        }

        public Blog GetByIdBL(int id)
        {
            return _blogDAL.GetByIdDAL(id);
        }
    }
}
