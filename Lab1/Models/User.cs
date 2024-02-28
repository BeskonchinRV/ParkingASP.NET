namespace Lab1.Models
{
    public class User
    {
        public User(int id,string name, string phone) 
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
