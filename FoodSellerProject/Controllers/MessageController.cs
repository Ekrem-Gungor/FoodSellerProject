using Businness_Layer.Concrete;
using Businness_Layer.ValidationRules;
using Data_Access_Layer.EntityFramework;
using Entitiy_Layer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace FoodSellerProject.Controllers
{
    public class MessageController : Controller
    {
        MessageManager mn = new MessageManager(new EfMessageDal());
        MessageValidator mv = new MessageValidator();

        public IActionResult Inbox()
        {
            var messageListIn = mn.GetListInbox();
            return View(messageListIn);
        }
        public IActionResult Sendbox()
        {
            var messageListSend = mn.GetListSendbox();
            return View(messageListSend);
        }
        public IActionResult GetInBoxMessageDetails(int id)
        {
            var values = mn.GetByID(id);
            return View(values);
        }
        public IActionResult GetSendBoxMessageDetails(int id)
        {
            var values = mn.GetByID(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewMessage(Message m)
        {
            ValidationResult result = mv.Validate(m);

            if (result.IsValid)
            {
                m.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                mn.messageAdd(m);
                return RedirectToAction("SendBox");
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
