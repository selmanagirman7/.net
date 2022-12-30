using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace WebUI.ViewComponents
{
    public class ProductHomeComponent:ViewComponent
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        public IViewComponentResult Invoke()
        {
            var result= productManager.GetAll().OrderBy(x => Guid.NewGuid()).Take(10);
            return View(result);
        }
    }
}
