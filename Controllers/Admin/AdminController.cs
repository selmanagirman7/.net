using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System.Globalization;
using System.IO;
using WebUI.Models;
using static System.Net.WebRequestMethods;

namespace WebUI.Controllers.Admin
{
    public class AdminController : Controller
    {
        DataAccess.AppContext context= new DataAccess.AppContext();
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        ContactManager contactManager = new ContactManager(new EfContactDal());
        GalleryManager galleryManager = new GalleryManager(new EfGalleryDal());
        ProductManager productManager = new ProductManager(new EfProductDal());
        ReferanceManager referanceManager = new ReferanceManager(new EfReferanceDal());
        BySeviceManager serviceManager = new BySeviceManager(new EfServiceDal());
        SliderManager sliderManager = new SliderManager(new EfSliderDal());


        //About
        #region About
        // About Start
        public IActionResult AboutList()
        {
            var result = aboutManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult AboutAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AboutAdd(About about)
        {
            about.Statu = true;
            about.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            aboutManager.Add(about);

            return RedirectToAction("AboutList", "Admin");
        }

        public IActionResult AboutDelete(int id)
        {

            var result = aboutManager.GetById(id);
            aboutManager.Delete(result);
            return RedirectToAction("AboutList", "Admin");
        }

        [HttpGet]
        public IActionResult AboutEdit(int id)
        {
            var result = aboutManager.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult AboutEdit(About about)
        {
            aboutManager.Update(about);
            return View("AboutList", "Admin");
        }
        #endregion


        // Category 
        #region Category

        public IActionResult CategoryList()
        {
            var result = categoryManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }



        [HttpPost]
        public IActionResult CategoryAdd(CategoryAdd item)
        {
            Category category = new Category();
            if (item.ImagePath != null)
            {
                var extension = Path.GetExtension(item.ImagePath.FileName);
                var newguid = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/urunler/" + newguid);

                var stream = new FileStream(location, FileMode.Create);

                item.ImagePath.CopyTo(stream);
                category.ImagePath = newguid;

            }
            category.Name=item.Name;
            category.NameDe = item.NameDe;
            category.NameEng= item.NameEng; 

            item.Statu = true;
            item.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            categoryManager.Add(category);
            return RedirectToAction("CategoryList");
        }

        public IActionResult CategoryDelete(int id)
        {
            var result = categoryManager.GetById(id);
            categoryManager.Delete(result);
            return View("CategoryList");
        }

        public IActionResult CategoryEdit()
        {
            return View();
        }
        #endregion


        //Contact 
        #region Contact

        public IActionResult ContactList()
        {
            var result = categoryManager.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult ContactAdd()
        {

            return View();
        }

        [HttpPost]
        public IActionResult ContactAdd(Contact contact)
        {
            contactManager.Add(contact);
            return RedirectToAction("ContactList");
        }


        public IActionResult ContactDelete(int id)
        {
            var result = contactManager.GetById(id);
            contactManager.Delete(result);
            return RedirectToAction("ContactList");
        }

        #endregion

        // Gallery
        #region Gallery
        public IActionResult GalleryList()
        {
            var result = galleryManager.GetAll();

            return RedirectToAction("result");
                 
        }

        [HttpGet]
        public IActionResult GalleryAdd( )
        {

            return View();
        }

        [HttpPost]
        public IActionResult GalleryAdd(Gallery gallery)
        {
            galleryManager.Add(gallery);
            return RedirectToAction("GalleryList");
        }


        public IActionResult GalleryDelete(int id)
        {
            var result = galleryManager.GetById(id);
            return View(result);
        }

        #endregion

        // Products

        #region Products
        public IActionResult ProductAdminList()
        {
            var result = productManager.GetAll();
            return View(result);
        }


        [HttpGet]
        public IActionResult ProductAdd()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            List<SelectListItem> categoryValues = (from x in cm.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View();
        }



        [HttpPost]
        public IActionResult ProductAdd(ProductAdd product)
        {

            Product p = new Product();
            if (product.ImagePath != null)
            {
                var extension = Path.GetExtension(product.ImagePath.FileName);
                var newguid = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/urunler/" + newguid);

                var stream = new FileStream(location, FileMode.Create);

                product.ImagePath.CopyTo(stream);
                p.ImagePath = newguid;

            }


            p.ProductName = product.ProductName;
            p.ProductNameDe = product.ProductNameDe;
            p.ProductNameEng = product.ProductNameEng;
            p.Quantity = product.Quantity;
            p.Ozellik1 = product.Ozellik1;
            p.Ozellik2 = product.Ozellik2;
            p.Ozellik3 = product.Ozellik3;
            p.Ozellik4 = product.Ozellik4;
            p.Ozellik5 = product.Ozellik5;
            p.Ozellik1De = product.Ozellik1De;
            p.Ozellik2De = product.Ozellik2De;
            p.Ozellik3De = product.Ozellik3De;
            p.Ozellik4De = product.Ozellik4De;
            p.Ozellik5De = product.Ozellik5De;
            p.Ozellik1Eng = product.Ozellik1Eng;
            p.Ozellik2Eng = product.Ozellik2Eng;
            p.Ozellik3Eng = product.Ozellik3Eng;
            p.Ozellik4Eng = product.Ozellik4Eng;
            p.Ozellik5Eng = product.Ozellik5Eng;
            p.OzellikDeger1 = product.OzellikDeger1;
            p.OzellikDeger2 = product.OzellikDeger2;
            p.OzellikDeger3 = product.OzellikDeger3;
            p.OzellikDeger4 = product.OzellikDeger4;
            p.OzellikDeger5 = product.OzellikDeger5;
            p.OzellikDeger1De = product.OzellikDeger1De;
            p.OzellikDeger2De = product.OzellikDeger2De;
            p.OzellikDeger3De = product.OzellikDeger3De;
            p.OzellikDeger4De = product.OzellikDeger4De;
            p.OzellikDeger5De = product.OzellikDeger5De;
            p.OzellikDeger1Eng = product.OzellikDeger1Eng;
            p.OzellikDeger2Eng = product.OzellikDeger2Eng;
            p.OzellikDeger3Eng = product.OzellikDeger3Eng;
            p.OzellikDeger4Eng = product.OzellikDeger4Eng;
            p.OzellikDeger5Eng = product.OzellikDeger5Eng;
            p.Price = product.Price;
            p.ProductDescription= product.ProductDescription;
            p.ProductDescriptionEng= product.ProductDescriptionEng;
            p.ProductDescriptionDe= product.ProductDescriptionDe;
            p.TumbDesc= product.TumbDesc;
            p.TumbName= product.TumbName;
            p.TumbNameEng= product.TumbNameEng;
            p.TumbNameDe= product.TumbNameDe;
            p.CategoryId= product.CategoryId;
            p.MonyType = product.MonyType;
            p.Statu = true;
            p.CreateDate= DateTime.Parse(DateTime.Now.ToShortDateString());
            productManager.Add(p);
            return RedirectToAction("ProductAdminList", "Admin");

        }




        public async Task<ActionResult> ProductEdit(int id)
        {
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            List<SelectListItem> categoryValues = (from x in cm.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            Product item = await context.Products.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);

        }
        [HttpPost]
        public async Task<ActionResult> ProductEdit(ProductAdd item)
        {
            Product product = new Product();
            if (ModelState.IsValid)
            {
                if (item.ImagePath != null)
                {
                    var extension = Path.GetExtension(item.ImagePath.FileName);
                    var newguid = Guid.NewGuid() + extension;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/urunler/" + newguid);

                    var stream = new FileStream(location, FileMode.Create);

                    item.ImagePath.CopyTo(stream);
                    product.ImagePath = newguid;

                }


                product.ProductName = item.ProductName;
                product.ProductNameDe = item.ProductNameDe;
                product.ProductNameEng = item.ProductNameEng;
                product.Quantity = item.Quantity;
                product.Ozellik1 = item.Ozellik1;
                product.Ozellik2 = item.Ozellik2;
                product.Ozellik3 = item.Ozellik3;
                product.Ozellik4 = item.Ozellik4;
                product.Ozellik5 = item.Ozellik5;
                product.Ozellik1De = item.Ozellik1De;
                product.Ozellik2De = item.Ozellik2De;
                product.Ozellik3De = item.Ozellik3De;
                product.Ozellik4De = item.Ozellik4De;
                product.Ozellik5De = item.Ozellik5De;
                product.Ozellik1Eng = item.Ozellik1Eng;
                product.Ozellik2Eng = item.Ozellik2Eng;
                product.Ozellik3Eng = item.Ozellik3Eng;
                product.Ozellik4Eng = item.Ozellik4Eng;
                product.Ozellik5Eng = item.Ozellik5Eng;
                product.OzellikDeger1 = item.OzellikDeger1;
                product.OzellikDeger2 = item.OzellikDeger2;
                product.OzellikDeger3 = item.OzellikDeger3;
                product.OzellikDeger4 = item.OzellikDeger4;
                product.OzellikDeger5 = item.OzellikDeger5;
                product.OzellikDeger1De = item.OzellikDeger1De;
                product.OzellikDeger2De = item.OzellikDeger2De;
                product.OzellikDeger3De = item.OzellikDeger3De;
                product.OzellikDeger4De = item.OzellikDeger4De;
                product.OzellikDeger5De = item.OzellikDeger5De;
                product.OzellikDeger1Eng = item.OzellikDeger1Eng;
                product.OzellikDeger2Eng = item.OzellikDeger2Eng;
                product.OzellikDeger3Eng = item.OzellikDeger3Eng;
                product.OzellikDeger4Eng = item.OzellikDeger4Eng;
                product.OzellikDeger5Eng = item.OzellikDeger5Eng;
                product.Price = item.Price;
                product.ProductDescription = item.ProductDescription;
                product.ProductDescriptionEng = item.ProductDescriptionEng;
                product.ProductDescriptionDe = item.ProductDescriptionDe;
                product.TumbDesc = item.TumbDesc;
                product.TumbName = item.TumbName;
                product.TumbNameEng = item.TumbNameEng;
                product.TumbNameDe = item.TumbNameDe;
                product.CategoryId = item.CategoryId;
                product.MonyType = item.MonyType;
                product.Statu = true;
                product.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                context.Update(product);
                await context.SaveChangesAsync();

                TempData["Success"] = "The item has been updated!";

                return RedirectToAction("ProductAdminList");
            }

            return View(item);
        }

        public IActionResult ProductDelete(int id)
        {

            var result =productManager.GetById(id);
            productManager.Delete(result);
            return RedirectToAction("ProductAdminList");
        }

        #endregion
    }
}
