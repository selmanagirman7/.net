﻿using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
