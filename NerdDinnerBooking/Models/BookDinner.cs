using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NerdDinner.Models
{
    public class BookDinner
    {
        [Key]
        public int DinnerId { get; set;}

        [ForeignKey("LoginViewModel")]
        public int CreatorId { get; set; }

        [Required]
        public string Title { get; set; }
        public string EventDate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string HostedBy { get; set; }
        [Required]
        public string ContactPhone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
