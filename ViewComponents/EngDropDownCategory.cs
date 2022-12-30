using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class EngDropDownCategory:ViewComponent
    {
        ICategoryService _categoryService;

        public EngDropDownCategory(ICategoryService categoryService)
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
