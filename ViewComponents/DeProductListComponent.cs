using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class DeProductListComponent:ViewComponent
    {
        IProductService _productService;

        public DeProductListComponent(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _productService.GetAll();
            return View();
        }
    }
}
