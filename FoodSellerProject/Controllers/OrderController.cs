using Businness_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace FoodSellerProject.Controllers
{
	public class OrderController : Controller
	{
		OrderManager om = new OrderManager(new EfOrderDal());
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult OrderByFood(int id)
		{
			var ordervalues = om.GetListByOrderID(id);
			return View(ordervalues);
		}

	}
}
