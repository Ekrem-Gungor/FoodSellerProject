using Businness_Layer.Concrete;
using Businness_Layer.ValidationRules;
using Data_Access_Layer.EntityFramework;
using Entitiy_Layer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace FoodSellerProject.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public IActionResult AddCategory() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category p) 
        {
            CategoryValidator categoryvalidator = new CategoryValidator();
            ValidationResult result = categoryvalidator.Validate(p);

            if (result.IsValid)
            {
                cm.categoryAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
        public IActionResult DeleteCategory(int id) 
        {
            var categoryvalue = cm.GetByID(id);
            cm.categoryDelete(categoryvalue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCategory(int id) 
        {
            var categoryvalue = cm.GetByID(id);

            return View(categoryvalue);
        }
        [HttpPost]
        public ActionResult EditCategory(Category p) 
        {
            cm.categoryUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
