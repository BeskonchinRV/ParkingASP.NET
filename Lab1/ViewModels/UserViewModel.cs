using Lab1.Models;

namespace Lab1.ViewModels
{
    public class UserViewModel
    {
        public User User { get;}

        public UserViewModel(User user)
        {
            User = user;
        }
    }
}
