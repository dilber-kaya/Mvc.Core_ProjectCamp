using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _1_MvcProject_UI.Controllers
{
    public class BlogController : Controller
    {
        BlogManagerBL bm = new BlogManagerBL(new EFBlogRepository());
        CategoryManagerBL cm = new CategoryManagerBL(new EFCategoryRepository());
        
        Context c = new Context();
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategoryBL();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;
            var values = bm.GetBlogByIdFilterBL(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var usermail = User.Identity.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = bm.GetListWithCategoryByWriterBL(writerID);
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryvalues = (from x in cm.ListBL()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            List<SelectListItem> categoryvalues = (from x in cm.ListBL()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;

            var usermail = User.Identity.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();

            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = writerID;
                bm.TAddBL(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult BlogDelete(int id)
        {
            var blogvalue = bm.GetByIdBL(id);
            bm.TDeleteBL(blogvalue);
            return RedirectToAction("BlogListByWriter");
        }

        [HttpGet]
        public IActionResult BlogEdit(int id)
        {
            var blogvalue = bm.GetByIdBL(id);
            List<SelectListItem> categoryvalues = (from x in cm.ListBL()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryvalues;
            return View(blogvalue);
        }

        [HttpPost]
        public IActionResult BlogEdit(Blog p)
        {
            var usermail = User.Identity.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();

            p.WriterID = writerID;
            p.BlogStatus = true;
            bm.TUpdateBL(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
