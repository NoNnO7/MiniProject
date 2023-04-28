using Microsoft.AspNetCore.Mvc;
using MiniProject.Models;

namespace MiniProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            User u1 = new User();
            u1.Id = 64010681;
            u1.Menu = "stake";
            u1.Option = "rare";
            u1.Location = "Ecc 802";

            User u2 = new User();
            u2.Id = 64010597;
            u2.Menu = "hamberger";
            u2.Option = "egg";
            u2.Location = "Ecc 801";

            User u3 = new User();
            u3.Id = 64010646;
            u3.Menu = "KFC";
            u3.Option = "-";
            u3.Location = "Ecc 805";

            User u4 = new User();
            u4.Id = 64010724;
            u4.Menu = "ramen";
            u4.Option = "egg";
            u4.Location = "Ecc 806";

            List<User> allUser = new List<User>();
            allUser.Add(u1);
            allUser.Add(u2);
            allUser.Add(u3);
            allUser.Add(u4);

            return View(allUser);
        }
        public IActionResult Info()
        {
            return View();
        }
    }
}
