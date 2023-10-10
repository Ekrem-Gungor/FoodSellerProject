using Businness_Layer.Concrete;
using Data_Access_Layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace FoodSellerProject.Controllers
{
    public class GalleryController : Controller
    {
        ImageFileManager ifm = new ImageFileManager(new EfImageFileDal());
        public IActionResult Index()
        {
            var files = ifm.GetList();
            return View(files);
        }

    }
}
