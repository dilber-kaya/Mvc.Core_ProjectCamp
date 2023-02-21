using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentServiceBL
	{
		void AddCommentBL(Comment comment);
		//void DeleteCommentBL(Comment comment);
		//void UpdateCommentBL(Comment comment);
		List<Comment> ListCommentBL(int id);
        //Comment GetByIdCommentBL(int id);
        List<Comment> GetCommentListWithBlogBL();

    }
}
