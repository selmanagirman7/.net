using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class NavbarCategoryComponent:ViewComponent
    {
        ICategoryDal _categoryDal;

        public NavbarCategoryComponent(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IViewComponentResult Invoke()
        {
            var result = _categoryDal.GetAll();
            return View(result);
        }
    }
}
