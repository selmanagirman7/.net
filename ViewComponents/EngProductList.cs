using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class EngProductList:ViewComponent
    {
        IProductService _productService;

        public EngProductList(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _productService.GetAll().OrderBy(x => Guid.NewGuid()).Take(20);
            return View(result);
        }
    }
}
