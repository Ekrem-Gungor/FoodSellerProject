using Businness_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FoodSellerProject.Controllers
{
    public class AboutController : Controller
	{

		AboutManager abm = new AboutManager(new EfAboutDal());

		public IActionResult Index()
		{
			var aboutvalues = abm.GetList();
			return View(aboutvalues);
		}

		[HttpGet]
		public IActionResult AddAbout()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddAbout(About p)
		{
            abm.AboutAdd(p);
			return RedirectToAction("Index");
		}

		public PartialViewResult AboutPartial()
		{
			return PartialView();
		}
	}
}
