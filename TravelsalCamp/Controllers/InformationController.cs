﻿using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
