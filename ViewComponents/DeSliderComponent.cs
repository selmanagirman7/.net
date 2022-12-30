using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class DeSliderComponent:ViewComponent
    {
        ISliderService _sliderService;

        public DeSliderComponent(ISliderService sliderService)
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
