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
    public class CategoryController : Controller
    {
        Context context = new Context();
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var result = categoryManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            categoryManager.Add(category);
            return RedirectToAction("Index");
        }


        public IActionResult CategoryDelete(int id)
        {
            var result = categoryManager.Get(id);
            categoryManager.Delete(result);
            return RedirectToAction("Index");
        }


        public async Task<ActionResult> Edit(int id)
        {
            Category item = await context.Categories.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);

        }
        [HttpPost]
        public async Task<ActionResult> Edit(Category item)
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


    }
}
