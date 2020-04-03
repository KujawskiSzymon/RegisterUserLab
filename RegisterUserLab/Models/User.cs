using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterUserLab.Models
{
    public class User 
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Imie jest polem obowiązkowym")]
        [StringLength(100, ErrorMessage = "Imie musi mieć min 1 litere",MinimumLength =1)]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Nazwisko jest polem obowiązkowym")]
        [StringLength(100, ErrorMessage = "nazwisko musi mieć min 1 litere", MinimumLength = 1)]
        public string? Surname { get; set; }

        public string? Position { get; set; } 
        [Required(ErrorMessage = "Email jest polem obowiązkowym")]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "email musi mieć min 1 litere", MinimumLength = 1)]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Login jest polem obowiązkowym")]
        [StringLength(100, ErrorMessage = "login musi mieć min 1 znak", MinimumLength = 1)]
        public string? Login { get; set; }
        [Required(ErrorMessage = "Hasło jest polem obowiązkowym")]
        [StringLength(100, ErrorMessage = "haslo musi mieć min 1 znak", MinimumLength = 1)]
        public string? Password { get; set; }
        [Required]
        
        public bool isMale { get; set; }
        public bool isAccountActive { get; set; } = true;
        public DateTime RegisterDate { get; set; } = DateTime.Now;

        [Compare("Password", ErrorMessage = "Niezgodne hasła.")]
        public string confPassword { get; set; }
    }
}
