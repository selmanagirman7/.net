using Business.Concrete;
using DataAccess;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class HumanResourceController : Controller
    {

        Context context = new Context();
        CorporateManager corporateManager = new CorporateManager(new EfCorporateDal());
        
        public IActionResult Index()
        {
            var result = corporateManager.GetAll();
            return View(result);
        }


        public IActionResult AdminList()
        {
            var result = corporateManager.GetAll();

            return View(result);
        }


        public IActionResult HumanAdd()
        {
    
            return View();
        }



        [HttpPost]
        public IActionResult HumanAdd(Corporate corporate)
        {
            corporateManager.Add(corporate);
            return RedirectToAction("AdminList","HumanResource");
        }


        public IActionResult Delete(int id)
        {
            var result = corporateManager.Get(id);
            corporateManager.Delete(result);
            return RedirectToAction("AdminList");
        }





    }
}
