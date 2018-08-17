using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dependency_injection.Models;
using dependency_injection.Interfaces;

namespace dependency_injection.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILog _log;

        public HomeController(ILog log)
        {
            _log = log;
        }

        public async Task<IActionResult> Index()
        {
            _log.write("HomeController Log");
            await _log.WriteMessage("test 123");

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
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
