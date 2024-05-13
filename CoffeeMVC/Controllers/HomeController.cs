using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



    }
}
