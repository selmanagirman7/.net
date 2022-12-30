using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class FooterContactBig:ViewComponent
    {
        IContactService _contactService;

        public FooterContactBig(IContactService contactService)
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
