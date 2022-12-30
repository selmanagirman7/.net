using Business.Abstract;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebUI.Models;
using DataAccess;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
         DataAccess.AppContext context = new  DataAccess.AppContext();
        private readonly ILogger<HomeController> _logger;
        IProductService _productService;


        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;

        }

        [HttpGet]
        public IActionResult Search(string Search)
        {
            List<Product> products;
            if (Search != "" && Search !=null)
            {
                products = context.Products
                    .Where(x => x.ProductName.Contains(Search.ToLower()) || x.TumbName.Contains(Search) || x.ProductDescription.Contains(Search) ).ToList();
            }
            else
            {
                products = context.Products.ToList();
            }

            return View(products);
        }
        [HttpGet]
        public IActionResult SearchEng(string Search)
        {
            List<Product> products;
            if (Search != "" && Search != null)
            {
                products = context.Products
                    .Where(x => x.ProductName.Contains(Search.ToLower()) || x.TumbName.Contains(Search) || x.ProductDescription.Contains(Search)).ToList();
            }
            else
            {
                products = context.Products.ToList();
            }

            return View(products);
        }

        [HttpGet]
        public IActionResult SearchDe(string Search)
        {
            List<Product> products;
            if (Search != "" && Search != null)
            {
                products = context.Products
                    .Where(x => x.ProductName.Contains(Search.ToLower()) || x.TumbName.Contains(Search) || x.ProductDescription.Contains(Search)).ToList();
            }
            else
            {
                products = context.Products.ToList();
            }

            return View(products);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexEng()
        {
            return View();
        }


        public IActionResult IndexDe()
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