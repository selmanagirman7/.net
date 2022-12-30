using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class FooterContact:ViewComponent
    {
        IContactService _contactService;

        public FooterContact(IContactService contactService)
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
