using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class DeFooterContact:ViewComponent
    {
        IContactService _contactService;

        public DeFooterContact(IContactService contactService)
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
