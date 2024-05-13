using CoffeeMVC.Business.Exceptions;
using CoffeeMVC.Business.Extensions;
using CoffeeMVC.Business.Services.Abstracts;
using CoffeeMVC.Core.Models;
using CoffeeMVC.Core.RepositoryAbstracts;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMVC.Business.Services.Concretes
{
    public class SliderService : ISliderService
    {
        private readonly ISliderRepository _sliderRepository;
        private readonly IWebHostEnvironment  _env;

        public SliderService(ISliderRepository sliderRepository, IWebHostEnvironment env)
        {
            _sliderRepository = sliderRepository;
            _env = env;
        }
        public async Task AddAsyncSlider(Slider slider)
        {

            slider.ImageUrl = Helper.ImageSaveContentRoot(_env.WebRootPath, @"\uploads\sliders\", slider.ImageFile);

            await _sliderRepository.AddAsync(slider);
            await _sliderRepository.CommitAsync(); 

        }

        public void DeleteSlider(int id)
        {
            throw new NotImplementedException();
        }

        public List<Slider> GetAllSliders(Func<Slider, bool>? func = null)
        {
            return _sliderRepository.GetAll();
        }

        public Slider GetSlider(Func<Slider, bool>? func = null)
        {
            return _sliderRepository.Get();
        }

        public void Update(int id, Slider newSlider)
        {
            throw new NotImplementedException();
        }
    }
}
