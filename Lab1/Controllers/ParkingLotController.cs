using Lab1.Models;
using Lab1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class ParkingLotController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            var parkingLots = new List<ParkingLot>
            {
                new ParkingLot(1,"Novosibirsk", 1000),
                new ParkingLot(2,"Ekaterinburg", 1500),
                new ParkingLot(3,"Moskva", 2000)
            };

            var parkingLotViewModels = new List<ParkingLotViewModel>();

            foreach (var parkingLot in parkingLots)
            {
                var parkingLotViewModel = new ParkingLotViewModel(parkingLot);
                parkingLotViewModels.Add(parkingLotViewModel);
            }
            return View(parkingLotViewModels);
        }
    }
}
