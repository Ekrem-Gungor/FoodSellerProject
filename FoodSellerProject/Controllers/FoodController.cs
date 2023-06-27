using Businness_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Entitiy_Layer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FoodSellerProject.Controllers
{
    public class FoodController : Controller
    {
        FoodManager fm = new FoodManager(new EfFoodDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var Foodvalues = fm.GetList();
            return View(Foodvalues);
        }
        [HttpGet]
        public IActionResult AddFood() 
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.vlc = valuecategory;
            return View();
        }
        [HttpPost]
        public IActionResult AddFood(Foods p) 
        {
            fm.foodAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult OrderByFood()
        {
            return View();
        }
    }
}
