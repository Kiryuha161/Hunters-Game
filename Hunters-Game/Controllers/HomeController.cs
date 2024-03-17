using Hunters_Game.Common.Utils;
using Hunters_Game.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace Hunters_Game.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            GetCurrentDate();

            return View();
        }

        public void GetCurrentDate()
        {
            DateTime currentDate = Utils.GetCurrentDate();
            ViewBag.CurrentDate = currentDate.ToString().Replace("0:00:00", "");
        }

        public DateTime ReturnCurrentDate()
        {
            return Utils.GetCurrentDate();
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

        public IActionResult AddDay()
        {
            Utils.AddDay();

            return RedirectToAction("Index");
        }

        public IActionResult ResetDate()
        {
            Utils.ResetTime();

            return RedirectToAction("Index");
        }
    }
}