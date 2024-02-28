using Lab1.Models;
using Lab1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class UserController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            var users = new List<User>
            {
                new User (1, "Roman", "89231272253"),
                new User (2, "Sasha", "89233072253"),
                new User (3, "Fedor", "89235072253"),
            };

            var userViewModels = new List<UserViewModel>();

            foreach (var user in users)
            {
                var userViewModel = new UserViewModel(user);
                userViewModels.Add(userViewModel);
            }
            return View(userViewModels);
        }
    }
}
