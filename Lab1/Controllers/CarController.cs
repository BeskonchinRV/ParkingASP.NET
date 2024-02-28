using Lab1.Models;
using Lab1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class CarController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            var cars = new List<Car>
            {
                new Car(1, "Ferrari", 2020),
                new Car(2, "Lamborghini", 2020),
                new Car(3, "Porsche", 2020)
            };

            var carViewModels = new List<CarViewModel>();

            
            foreach (var car in cars)
            {
                var carViewModel = new CarViewModel(car);
                carViewModels.Add(carViewModel);
            }

            
            return View(carViewModels);
        }
    }
}
