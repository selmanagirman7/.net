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
    public class ContactController : Controller
    {
        Context context = new Context();
        ContactManager contactManager = new ContactManager(new EfContactDal());
        

        public IActionResult Index()
        {
            var result = contactManager.GetAll();
            return View(result);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contactManager.Add(contact);
            return View();
        }

        public IActionResult AdminList()
        {
            var result = contactManager.GetAll();
            return View(result);
        }


        public IActionResult ContactDelete(int id)
        {
            var result = contactManager.Get(id);
            contactManager.Delete(result);
            return RedirectToAction("AdminList");
        }


        public async Task<ActionResult> Edit(int id)
        {
            Contact item = await context.Contacts.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);

        }


        [HttpPost]
        public async Task<ActionResult> Edit(Contact item)
        {
            if (ModelState.IsValid)
            {
                context.Update(item);
                await context.SaveChangesAsync();

                TempData["Success"] = "The item has been updated!";

                return RedirectToAction("AdminList");
            }

            return View(item);
        }

        [HttpGet]
        public IActionResult ContactAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactAdd(Contact contact)
        {
            contactManager.Add(contact);
            return RedirectToAction("Adminlist");
        }


        public IActionResult AdminContact()
        {
            var result = contactManager.GetAll();
            return View(result);
        }
        public IActionResult AdminContactDetail(int id)
        {
            var result = contactManager.Get(id);
            return View(result);
        }

    }
}
