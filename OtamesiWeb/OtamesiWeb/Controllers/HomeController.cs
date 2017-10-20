using Microsoft.AspNetCore.Mvc;
using OtamesiWeb.Models;
using StandardLib;
using System.Diagnostics;

namespace OtamesiWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            new Class1().Itb();
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string Itb()
        {
            var x = new Class1();
            return x.Itb2();
        }
    }
}
