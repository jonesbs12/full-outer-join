using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace WeddApp.Models
{
    public class RSVP
    {
        public int ID { get; set; }

        [Required]
        [Range(0, 10)]
        [Display(Name = "Number of Persons Attending")]
        public int NumAttending { get; set; }

        [Required(ErrorMessage = "Invalid Character. Use the following format: John Doe, Jane Doe, Jimmy Doe")]
        [RegularExpression(@"^[a-zA-Z0-9'' ',\.]+$")]
        [Display(Name = "Name of Persons Attending")]
        public string Name { get; set; }

        [Display(Name = "AcceptRegret")]
        public string AcceptRegret { get; set; }

        [Range(0, 10)]
        [Display(Name = "Number of Kids Meals Needed(Kids Under 12)")]
        public int NumKidsMeal { get; set; }

        [Display(Name = "Questions, Comments, Allergy Information")]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }
    }

    public class RSVPDBContext : DbContext
    {
        public DbSet<RSVP> RSVPs { get; set; }
    }
}