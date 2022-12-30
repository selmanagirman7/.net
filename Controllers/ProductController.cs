using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {

       IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var result = _productService.GetAll();
            return View(result);
        }

        public IActionResult IndexDe()
        {
            var result = _productService.GetAll();

            return View(result);
        }

        public IActionResult IndexEng()
        {
            var result = _productService.GetAll();

            return View(result);
        }


        public IActionResult GetDetail(int id)
        {
            var result = _productService.GetByDetail(id);
            return View(result);

        }

        public IActionResult GetDetailDe(int id)
        {
            var result = _productService.GetByDetail(id);
            return View(result);

        }

        public IActionResult GetDetailEng(int id)
        {
            var result = _productService.GetByDetail(id);
            return View(result);

        }
        public IActionResult GetByCategory(int id)
        {
            var result = _productService.GetByCategory(id);
            return View(result);
        }

        public IActionResult GetByCategoryEng(int categoryId)
        {
            var result = _productService.GetByCategory(categoryId);
            return View(result);
        }

        public IActionResult GetByCategoryDe(int categoryId)
        {
            var result = _productService.GetByCategory(categoryId);
            return View(result);
        }
    }
}
