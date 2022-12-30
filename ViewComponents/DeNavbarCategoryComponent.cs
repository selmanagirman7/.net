using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class DeNavbarCategoryComponent:ViewComponent
    {
        ICategoryDal _categoryDal;

        public DeNavbarCategoryComponent(ICategoryDal categoryDal)
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
