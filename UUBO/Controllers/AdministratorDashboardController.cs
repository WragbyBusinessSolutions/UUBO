using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UUBO.Models;

namespace UUBO.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdministratorDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
           public IActionResult CreateWill()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
