using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class ReferanceComponent:ViewComponent
    {
        ReferanceManager referanceManager = new ReferanceManager(new EfReferanceDal());
        public IViewComponentResult Invoke()
        {
            var result = referanceManager.GetAll();
            return View(result);
        }
    }
}

