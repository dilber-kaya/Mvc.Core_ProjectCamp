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
	public class CommentManagerBL : ICommentServiceBL
	{
		ICommentDAL _commentDAL;

		public CommentManagerBL(ICommentDAL commentDAL)
		{
			_commentDAL = commentDAL;
		}

		public void AddCommentBL(Comment comment)
		{
			_commentDAL.InsertDAL(comment);
		}

        public List<Comment> GetCommentListWithBlogBL()
        {
			return _commentDAL.GetListWithBlogDAL();
        }

        public List<Comment> ListCommentBL(int id)
		{
			return _commentDAL.ListDAL(x => x.BlogID == id);
		}
	}
}
