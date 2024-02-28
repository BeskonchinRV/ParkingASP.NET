using Lab1.Models;

namespace Lab1.ViewModels
{
    public class ParkingLotViewModel
    {
        public ParkingLot ParkingLot {  get; }

        public ParkingLotViewModel(ParkingLot parkingLot) 
        { 
            ParkingLot = parkingLot;
        }
    }
}
