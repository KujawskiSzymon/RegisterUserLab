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
        [Required]
        public string Name { get; set; }
        [Required]
        public string Nazwisko { get; set; }

        public string Stanowisko{ get; set; } 
        [Required]
        public string Email { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Haslo { get; set; }
        [Required]
        public bool isMale { get; set; }
        public bool isAccountActive { get; set; } = true;
        public DateTime RegisterDate { get; set; } = DateTime.Now;
    }
}
