using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class EngProductPageCategory:ViewComponent
    {
        ICategoryService _categoryService;

        public EngProductPageCategory(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _categoryService.GetAll();
            return View(result);
        }
    }
}

