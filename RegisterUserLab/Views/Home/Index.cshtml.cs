using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RegisterUserLab.Models;

namespace RegisterUserLab.Views.Home
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }
        public void OnGet()
        {
            if(User == null)
            {
                User = new User() { Name="",confPassword="",Email="",Login="",Password="",Surname=""};

            }
            Page();
        }
    }
}
