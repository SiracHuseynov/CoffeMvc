using Microsoft.AspNetCore.Mvc;

namespace CoffeeMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
