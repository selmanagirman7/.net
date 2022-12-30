using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class EngFooterContact:ViewComponent
    {
        IContactService _contactService;

        public EngFooterContact(IContactService contactService)
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
