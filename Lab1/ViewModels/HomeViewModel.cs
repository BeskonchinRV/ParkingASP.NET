namespace Lab1.ViewModels
{
    public class HomeViewModel
    {
        public List<CarViewModel> CarViewModels { get; set; }
        public List<UserViewModel> UserViewModels { get; set; }
        public List<ParkingLotViewModel> ParkingLotViewModels { get; set; }

        public HomeViewModel()
        {
            CarViewModels = new List<CarViewModel>();
            UserViewModels = new List<UserViewModel>();
            ParkingLotViewModels = new List<ParkingLotViewModel>();
        }
    }
}
