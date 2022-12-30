using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class SliderComponent:ViewComponent
    {
        SliderManager sliderManager = new SliderManager(new EfSliderDal());
        public IViewComponentResult Invoke()
        {
            var result= sliderManager.GetAll();
            return View(result);
        }
    }
}
