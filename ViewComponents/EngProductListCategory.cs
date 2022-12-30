using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class EngProductListCategory:ViewComponent
    {
        IProductService _productService;

        public EngProductListCategory(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _productService.GetAll();
            return View(result);
        }
    }
}
