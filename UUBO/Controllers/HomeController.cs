﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UUBO.Models;

namespace UUBO.Controllers
{
    [Authorize(Roles ="User")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
           public IActionResult CreateWill()
        {
            return View();
        }

        public IActionResult Preview()
        {
            return View();
        }
     
        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
