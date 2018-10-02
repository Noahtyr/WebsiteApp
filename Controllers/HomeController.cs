using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebsiteApp.Models;

namespace WebsiteApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutDirtyTactics()
        {
            ViewData["Message"] = "The Community for the Dirty";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Who to contact and where.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Games()
        {
            ViewData["Message"] = "What games do we play?";

            return View();
        }

        public IActionResult WowPage()
        {
            ViewData["Message"] = "About that one game we play";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
