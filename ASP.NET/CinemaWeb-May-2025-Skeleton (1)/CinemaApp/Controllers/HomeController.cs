using CinemaApp.Data;
using CinemaApp.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace CinemaApp.Web.Controllers
{




    public class HomeController(CinemaAppMay2025DbContext logger) : Controller
    {
        
        public IActionResult Index()
        {
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
