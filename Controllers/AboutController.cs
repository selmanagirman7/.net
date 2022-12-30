using Business.Concrete;
using DataAccess;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        Context context = new Context();
        AboutManager aboutManager = new AboutManager(new EfAboutDal());


        public IActionResult Index()
        {
            var result = aboutManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult AboutAdd()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AboutAdd(About about)
        {
            aboutManager.Add(about);
            return RedirectToAction("AdminList","About");
        }


        public async Task<ActionResult> Edit(int id)
        {
            About item = await context.Abouts.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);

        }


        public IActionResult AboutDelete(int id)
        {
            var result = aboutManager.Get(id);
            aboutManager.Delete(result);
            return RedirectToAction("AdminList");
        }

        [HttpPost]
        public async Task<ActionResult> Edit(About item)
        {
            if (ModelState.IsValid)
            {
                context.Update(item);
                await context.SaveChangesAsync();

                TempData["Success"] = "The item has been updated!";

                return RedirectToAction("Index");
            }

            return View(item);
        }


          public IActionResult AdminList()
        {
            var result = aboutManager.GetAll();
            return View(result);
        }
    }
}
