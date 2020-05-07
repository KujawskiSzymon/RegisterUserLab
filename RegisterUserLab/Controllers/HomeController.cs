using System;
using System.Collections.Generic;
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
               UserRegister = new User() { Name = "", confPassword = "", Email = "", Login = "", Password = "", Surname = "" };
            }
            return View(UserRegister);
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LoginDo(User user)
        {
            return View();
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
            if (ModelState.IsValid)
            {
                Debug.WriteLine("Jest ok");
                return View();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
