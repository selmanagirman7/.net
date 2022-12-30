using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class PopProduct:ViewComponent
    {
        IProductService _productService;

        public PopProduct(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var result = _productService.GetByDetail(id);
            return View(result);    
        }
    }
}
