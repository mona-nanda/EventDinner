using System;
using System.ComponentModel.DataAnnotations;
namespace NerdDinner.Models
{
    public class LoginViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
