using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NerdDinner.Models
{
    public class Rsvp
    {   [Key]
        public int RsvpId { get; set; }

        [ForeignKey("BookDinner")]
        public int DinnerId { get; set; }

        [Required]
        public string AttendeeName { get; set; }
    }
}
