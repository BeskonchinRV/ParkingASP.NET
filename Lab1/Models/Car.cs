namespace Lab1.Models
{
    public class Car
    {
        public Car(int id, string model,int age)
        {
            this.Id = id;
            this.Model = model;
            this.AgeCar = age;
        }

        public int Id { get; set; }
        public string Model { get; set; }
        public int AgeCar { get; set; }
    }
}
