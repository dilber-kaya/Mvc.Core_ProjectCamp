using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace _1_MvcProject_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class CategoryController : Controller
    {
        CategoryManagerBL cm = new CategoryManagerBL(new EFCategoryRepository());
        public IActionResult Index(int page = 1)
        {
            var values = cm.ListBL().ToPagedList(page, 3);
            return View(values);
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            CategoryValidator cv = new CategoryValidator();
            ValidationResult results = cv.Validate(p);
            if (results.IsValid)
            {
                p.CategoryStatus = true;
                cm.TAddBL(p);
                return RedirectToAction("Index", "Category");
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
        public IActionResult CategoryDelete(int id)
        {
            var value = cm.GetByIdBL(id);
            cm.TDeleteBL(value);
            return RedirectToAction("Index");
        }
    }
}
