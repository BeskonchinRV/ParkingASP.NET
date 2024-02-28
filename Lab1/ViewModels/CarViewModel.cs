using Lab1.Models;

namespace Lab1.ViewModels
{
    public class CarViewModel
    {
        public Car Car { get; }

        public CarViewModel(Car car)
        {
            Car = car;
        }
    }
}
