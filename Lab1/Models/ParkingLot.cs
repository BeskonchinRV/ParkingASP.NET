namespace Lab1.Models
{
    public class ParkingLot
    {
        public ParkingLot(int id, string location, int price) 
        { 
            this.Id = id;
            this.Location = location;
            this.Price = price;
        }
        public int Id { get; set; }
        public string Location { get; set; }
        public int Price { get; set; }
    }
}
