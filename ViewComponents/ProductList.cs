using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class ProductList:ViewComponent
    {
        IProductService _productService;

        public ProductList(IProductService productService)
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
