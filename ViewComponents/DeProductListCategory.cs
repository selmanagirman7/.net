using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class DeProductListCategory:ViewComponent
    {
        IProductService _productService;

        public DeProductListCategory(IProductService productService)
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
