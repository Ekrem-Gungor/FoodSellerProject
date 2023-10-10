using Businness_Layer.Concrete;
using Businness_Layer.ValidationRules;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace FoodSellerProject.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();

        public IActionResult Index()
        {
            var contactValues = cm.GetList();
            return View(contactValues);
        }

        public IActionResult GetContactDetails(int id)
        {
            var contactValues = cm.GetByID(id);
            return View(contactValues);
        }

        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}
