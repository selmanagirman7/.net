using DataAccess;
using Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(Client client)
        {

            Context context = new Context();
            var DataValue = context.Clients.FirstOrDefault(x => x.Name == client.Name && x.Password == client.Password);
            if (DataValue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, client.Name),
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("AdminList", "Product");
            }
            else
            {
                return View();
            }





        }
    }
}
