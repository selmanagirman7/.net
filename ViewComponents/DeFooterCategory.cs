using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class DeFooterCategory:ViewComponent
    {
        ICategoryService _categoryService;

        public DeFooterCategory(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _categoryService.GetAll().OrderBy(x => Guid.NewGuid()).Take(5);
            return View(result);
        }
    }
}
