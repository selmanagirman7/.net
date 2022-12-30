using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class CatologController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
