using Microsoft.AspNetCore.Mvc;
using BackendModules.Models;
using System.Diagnostics;

namespace BackendModules.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Departments()
        {
            return RedirectToAction("Index", "Departments");
        }

        public IActionResult Reminders()
        {
            return RedirectToAction("Index", "Reminders");
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
