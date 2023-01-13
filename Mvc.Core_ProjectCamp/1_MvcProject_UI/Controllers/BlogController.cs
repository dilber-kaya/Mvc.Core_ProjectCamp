using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _1_MvcProject_UI.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManagerBL bm = new BlogManagerBL(new EFBlogRepository());
        CategoryManagerBL cm = new CategoryManagerBL(new EFCategoryRepository());
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
           var values = bm.GetListWithCategoryByWriterBL(1);
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

            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = 1;
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
            p.WriterID = 1;
            p.BlogStatus = true;
            bm.TUpdateBL(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
