using _1_MvcProject_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					ID= 1,
					UserName="Dilber"
				},
				new UserComment
				{
					ID= 2,
					UserName="Zeynep"
				},
				new UserComment
				{
					ID= 3,
					UserName="Erdem"
				}
			};
			return View(commentvalues);
		}
	}
}
