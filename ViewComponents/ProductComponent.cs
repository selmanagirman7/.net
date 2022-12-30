using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.ViewComponents
{
    public class ProductComponent:ViewComponent
    {
        VegaManager productManager =new VegaManager(new EfVegaDal()); 

        public IViewComponentResult Invoke()
        {
            var result = productManager.GetAll().OrderBy(x => Guid.NewGuid()).Take(8);
            return View(result);
        }
    }
}
