using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AboutController : Controller
    {
       IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var result = _aboutService.GetAll();
            return View(result);
        }

        public IActionResult IndexDe()
        {
            var result = _aboutService.GetAll();
            return View(result);
        }

        public IActionResult IndexEng()
        {
            var result = _aboutService.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult AboutAdd()
        {

            var result = _aboutService.GetAll();
            return View(result);
        }

   

    }
}
