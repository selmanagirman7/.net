using DataAccess;
using Entity;
using Korzh.EasyQuery.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;
using X.PagedList;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        Context context = new Context();

        public IActionResult Index(/*string SearchText=" "*/)
        {

           // var results = context.VegaProducts
           //.Where(x => x.Name.Contains(SearchText) || x.Stok.Contains(SearchText))
           //    .ToList();
           // //List<Vega> vega;
           // //if (terms != "" && terms != null)
           // //{

           // //    vega = context.VegaProducts
           // //        .Where(x => x.Name.Contains(terms) || x.Stok.Contains(terms))
           // //        .ToList();
           // //}
           // //else
           // //{
           // //    vega = context.VegaProducts.ToList();
           // //}

            return View();
        }

   



        [HttpGet]
        public  IActionResult Search(string Search, int syf = 1)
        {

            List<Vega> vega;
            if (Search != "" && Search != null)
            {
                vega = context.VegaProducts
                    .Where(x => x.Name.Contains(Search.ToUpper()) || x.CategoryName.Contains(Search.ToUpper()) || x.Stok.Contains(Search.ToUpper())||x.ImageUrl.Contains(Search))
                    .ToList();
            }
            else
            {
                vega = context.VegaProducts.ToList();
            }

            return View(vega);

            //try
            //{
            //    var prquery = from x in context.VegaProducts select x;
            //    if (!string.IsNullOrEmpty(Search))
            //    {
            //        prquery = prquery.Where(x => x.Name.Contains(Search.ToUpper()) || x.CategoryName.ToUpper().Contains(Search.ToUpper()) || x.Stok.ToUpper().Contains(Search.ToUpper()));
            //    }
            //    return  View(prquery.ToPagedList(syf, 350));

            //}
            //catch (Exception ex)
            //{


            //    _logger.LogError(ex, ex.Message);
            //    string msg = ex.Message;

            //}

        }

        public IActionResult Banka()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

