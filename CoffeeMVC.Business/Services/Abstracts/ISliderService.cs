using CoffeeMVC.Core.Models;
using CoffeeMVC.Core.RepositoryAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMVC.Business.Services.Abstracts
{
    public interface ISliderService
    {
        Task AddAsyncSlider(Slider slider);
        void DeleteSlider(int id);
        void Update(int id, Slider newSlider);
        Slider GetSlider(Func<Slider, bool>? func = null);
        List<Slider> GetAllSliders(Func<Slider, bool>? func = null);

    }
}
