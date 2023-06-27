using Businness_Layer.Concrete;
using Businness_Layer.ValidationRules;
using Data_Access_Layer.EntityFramework;
using Entitiy_Layer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace FoodSellerProject.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager cm = new CustomerManager(new EfCustomerDal());
        CustomerValidator customervalidator = new CustomerValidator();
        public IActionResult Index()
        {
            var CustomerValues = cm.GetList();
            return View(CustomerValues);
        }
        [HttpGet]
        public IActionResult AddCustomer() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            ValidationResult result = customervalidator.Validate(p);

            if (result.IsValid) 
            {
                cm.CustAdd(p);
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
        [HttpGet]
        public IActionResult EditCustomer(int id) 
        {
            var customervalue = cm.GetByID(id);
            return View(customervalue);
        }
        [HttpPost]
        public IActionResult EditCustomer(Customer p)
        {
            ValidationResult result = customervalidator.Validate(p);

            if (result.IsValid)
            {
                cm.CustUpdate(p);
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
    }
}
