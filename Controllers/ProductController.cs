using Business.Concrete;
using ClosedXML.Excel;
using DataAccess;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers.Excel;
using WebUI.Models;
using X.PagedList;
using static ClosedXML.Excel.XLPredefinedFormat;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class ProductController : Controller
    {
        Vega Product = new Vega();
        public Context context = new Context();
        VegaManager productManager = new VegaManager(new EfVegaDal());
        private readonly IConfiguration configuration;
        private readonly ILogger<ExcelController> logger;

        public ProductController(IConfiguration configuration, ILogger<ExcelController> logger)
        {
            this.configuration = configuration;
            this.logger = logger;
        }


      
        public async Task<IActionResult> Index(int syf = 1, string SearchText = "")
        {
            List<Vega> vega;
            if (SearchText != "" && SearchText != null)
            {
                vega = context.VegaProducts
                    .Where(x => x.Name.Contains(SearchText) || x.Stok.Contains(SearchText))
                    .ToList();
            }
            else
            {
                vega = context.VegaProducts.ToList();
            }


            // İSKONTO FORMUL (İlk fiyat – indirimli fiyat) / ilk fiyat] x 100
            // (150 x %20 = 30 TL)
         
           
            
            return View(vega.ToPagedList(syf, 32));


        }

        public IActionResult Category(string strId)
        {
            var result = productManager.GetAllByStringId(strId);
            return View(result);
        }


        [HttpGet]
        public IActionResult ProductAdd()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            List<SelectListItem> categoryValues = (from x in cm.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text=x.CategoryName,
                                                       Value=x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View();
        }


        [HttpPost]
        public IActionResult ProductAdd(ProductAdd product)
        {

            Vega p = new Vega();
            if (product.ImageUrl != null)
            {
                var extension = Path.GetExtension(product.ImageUrl.FileName);
                var newguid = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/urunler/" + newguid);
                var stream = new FileStream(location, FileMode.Create);
                product.ImageUrl.CopyTo(stream);
                p.ImageUrl = newguid;

            }

            p.Name = product.Name;
            p.Stok = product.Stok;
            productManager.Add(p);
            return RedirectToAction("AdminList", "Product");

        }



        public IActionResult AdminList(int syf = 1, string SearchText = "")
        {
           

                List<Vega> vega;
                if (SearchText != "" && SearchText != null)
                {
                    vega = context.VegaProducts
                        .Where(x => x.Name.Contains(SearchText) || x.Stok.Contains(SearchText))
                        .ToList();
                }
                else
                {
                    vega = context.VegaProducts.ToList();
                }


        


                return View(vega.ToPagedList(syf, 32));
            }

        [HttpGet]
        public async Task<IActionResult> Search(string Search, int syf = 1)
        {

            List<Vega> vega;
            if (Search != "" && Search != null)
            {
                vega = context.VegaProducts
                    .Where(x => x.Name.Contains(Search.ToUpper()) || x.CategoryName.Contains(Search.ToUpper()) || x.Stok.Contains(Search.ToUpper()) || x.KeyWords.Contains(Search))
                    .ToList();
            }
            else
            {
                vega = context.VegaProducts.ToList();
            }

            return View(vega);

        }




        public IActionResult Detail(string name, int id)
        {

            var result = productManager.GetById(id);
            return View(result);
        }


       public IActionResult GetCategory(int id , int syf = 1)
        {
            try
            {
                var result = productManager.GetByCategory(id);
                return View(result.ToPagedList(syf,32));
            }

            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                string msg = ex.Message;
            }
            return View();

        }


        public async Task<ActionResult> Edit(int id)
        {
            Vega item = await context.VegaProducts.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);

        }
        [HttpPost]
        public async Task<ActionResult> Edit(Vega item)
        {
            if (ModelState.IsValid)
            {
                context.Update(item);
                await context.SaveChangesAsync();

                TempData["Success"] = "The item has been updated!";

                return RedirectToAction("AdminList");
            }

            return View(item);
        }

        public IActionResult ProductDelete(int id)
        {

            var result = productManager.Get(id);
            productManager.Delete(result);
            return RedirectToAction("AdminList");
        }


        public IActionResult SelectDelete(string[] empids, int syf = 1)
        {

            int[] getid = null;
            if (empids!=null)
            {
                getid = new int[empids.Length];
                int j = 0;
                foreach (string i in empids)
                {
                    int.TryParse(i,out getid[j++]);
                }
            
            List<Vega> getempids=new List<Vega>();
            Context ct=new Context();
            getempids=ct.VegaProducts.Where(x=>getid.Contains(x.Id)).ToList();

            foreach (var s in getempids)
            {
                ct.VegaProducts.Remove(s);
            }
            ct.SaveChanges();

            }
            return RedirectToAction("AdminList");
        }

        public IActionResult DeleteList(int id)
        {
            var result = productManager.GetByCategory(id);
            context.RemoveRange(result);
            context.SaveChanges();
            return RedirectToAction("AdminList");
        }
        public IActionResult AllDelete()
        {
            var result = productManager.GetAll();
            context.RemoveRange(result);
            context.SaveChanges();
            return RedirectToAction("AdminList");
        }
    }
}
