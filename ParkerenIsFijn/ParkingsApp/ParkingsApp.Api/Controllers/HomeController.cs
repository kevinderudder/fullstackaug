using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ParkingsApp.Api.Config;
using ParkingsApp.Api.Models;

namespace ParkingsApp.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<ParkingsAppSettings> appSettings;

        public HomeController(IOptions<ParkingsAppSettings> options)
        {
            this.appSettings = options;
        }


        public IActionResult Index()
        {
            ViewBag.Version = appSettings.Value.Version;
            ViewBag.Url = appSettings.Value.Url;
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
