using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Logging;
using RegisterUserLab.Models;

namespace RegisterUserLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        [BindProperty]
        private User? UserRegister { get; set; } 

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
        }
       
        public IActionResult Index()
        {
            if (UserRegister == null)
            {
               UserRegister = new User() { Name = "", confPassword = "",Position="", Email = "", Login = "", Password = "", Surname = "" };
            }
            return View(UserRegister);
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View("Admin");
        }
        public IActionResult UserHome()
        {
            return View("UserView");
        }

        public IActionResult LoginDo(User user)
        {
            return View("UserView");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User user)
        {
            Database database = new Database();
            string query = "INSERT INTO User ('Login','Password') VALUES (@Login, @Password)" ;
            SQLiteCommand command = new SQLiteCommand(query, database.Connection);
            database.OpenConnection();
            command.Parameters.AddWithValue("@Login", user.Login);
            command.Parameters.AddWithValue("@Password", user.Password);
            var result = command.ExecuteNonQuery();
            database.CloseConnection();
            
               
                return View("UserView");
            
            
        }
    }
}
