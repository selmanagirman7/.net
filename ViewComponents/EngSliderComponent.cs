using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class EngSliderComponent:ViewComponent
    {
        ISliderService _sliderService;

        public EngSliderComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _sliderService.GetAll();
            return View();
        }
    }
}
