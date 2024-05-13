using CoffeeMVC.Business.Services.Abstracts;
using CoffeeMVC.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public IActionResult Index()
        {
            var sliders = _sliderService.GetAllSliders();   
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Slider slider)
        {
            await _sliderService.AddAsyncSlider(slider);
            return RedirectToAction("Index");
        }
    }
}

