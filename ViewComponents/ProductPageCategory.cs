using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace WebUI.ViewComponents
{
    public class ProductPageCategory:ViewComponent
    {
        ICategoryDal _categoryDal;

        public ProductPageCategory(ICategoryDal categoryDal)
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
