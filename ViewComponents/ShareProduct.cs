using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class ShareProduct:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            VegaManager vegaManager = new VegaManager(new EfVegaDal());
            var result = vegaManager.GetAll();
            return View(result);
        }
    }
}
