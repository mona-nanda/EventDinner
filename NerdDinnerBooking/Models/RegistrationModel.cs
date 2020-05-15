using System;
using System.ComponentModel.DataAnnotations;
namespace NerdDinner.Models
{
    public class RegistrationModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 3)]
        //[StringLength(15, ErrorMessage = "Name length can't be more than 15.")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 6)]
        public string Password { get; set; }
      
    }
}
