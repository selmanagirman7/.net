using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class EngProductListComponent : ViewComponent
    {
        IProductService _productService;

        public EngProductListComponent(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            //var result = _productService.GetAll().OrderBy(x => Guid.NewGuid());
            return View();
        }
    }
}
