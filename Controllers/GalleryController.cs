using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class GalleryController : Controller
    {
        IGalleryService _galleryService;

        public GalleryController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public IActionResult Index()
        {
            var result = _galleryService.GetAll();
            return View(result);
        }
    }
}
