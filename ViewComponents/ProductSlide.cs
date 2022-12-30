using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace WebUI.ViewComponents
{
    public class ProductSlide:ViewComponent
    {
        VegaManager productManager = new VegaManager(new EfVegaDal());

        public IViewComponentResult Invoke()
        {
            var result = productManager.GetAll().OrderBy(x => Guid.NewGuid()).Take(20);
            return View(result);
        }
    }
}
