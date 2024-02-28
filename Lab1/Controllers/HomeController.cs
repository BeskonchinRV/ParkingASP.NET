using Lab1.Models;
using Lab1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          
            var cars = new List<Car>
            {
                new Car(1, "Ferrari", 2020),
                new Car(2, "Lamborghini", 2020),
                new Car(3, "Porsche", 2020)
            };

            var users = new List<User>
            {
                new User(1, "Roman", "89231272253"),
                new User(2, "Sasha", "89233072253"),
                new User(3, "Fedor", "89235072253")
            };

            var parkingLots = new List<ParkingLot>
            {
                new ParkingLot(1, "Novosibirsk", 1000),
                new ParkingLot(2, "Ekaterinburg", 1500),
                new ParkingLot(3, "Moskva", 2000)
            };

            var carViewModels = cars.Select(car => new CarViewModel(car)).ToList();
            var userViewModels = users.Select(user => new UserViewModel(user)).ToList();
            var parkingLotViewModels = parkingLots.Select(parkingLot => new ParkingLotViewModel(parkingLot)).ToList();

            var viewModel = new HomeViewModel
            {
                CarViewModels = carViewModels,
                UserViewModels = userViewModels,
                ParkingLotViewModels = parkingLotViewModels
            };

            return View(viewModel);
        }
    }
}
