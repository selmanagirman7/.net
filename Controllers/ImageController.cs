using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using WebUI.Models;
using Entity;
using Microsoft.AspNetCore.Authorization;

namespace WebUI.Controllers
{
    [AllowAnonymous]

    public class ImageController : Controller
    {
        ImageManager imageManager =new ImageManager(new EfImageDal());
        public IActionResult Index()
        {
            var result = imageManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult ImageAdd()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ImageAdd(ImageAdd imageAdd)
        {
            Image p = new Image();
            if (imageAdd.Name != null)
            {
                var extension = Path.GetExtension(imageAdd.Name.FileName);
                var newguid = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/urunler/" + newguid);
                var stream = new FileStream(location, FileMode.Create);
                imageAdd.Name.CopyTo(stream);
                p.Name = newguid;

            }

  
            imageManager.Add(p);

            return RedirectToAction("Index");
        }

        public IActionResult ImageDelete(int id)
        {
            var result = imageManager.Get(id);
            imageManager.Delete(result);
            return RedirectToAction("Index");
        }
    }
}
