using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class CategoryProduct:ViewComponent
    {
        IProductService _productService;

        public CategoryProduct(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _productService.GetAll().OrderBy(x=>Guid.NewGuid()).Take(6) ;
            return View(result);
        }
    }
}
