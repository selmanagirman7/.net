using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
namespace WebUI.ViewComponents
{
    public class EngFooterContactBig:ViewComponent
    {
        IContactService _contactService;

        public EngFooterContactBig(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _contactService.GetAll();
            return View(result);
        }
    }
}
