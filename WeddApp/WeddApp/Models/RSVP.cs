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

        [Range(0, 10, ErrorMessage = "Must be between 0 and 10.")]
        [Display(Name = "Number of Persons Attending")]
        public int NumAttending { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [RegularExpression(@"^[a-zA-Z0-9'' ',\.]+$", ErrorMessage = "Invalid input. Use the following format: John Doe, Jane Doe, Jimmy Doe")]
        [Display(Name = "Name of Persons Attending")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Accept or Decline the invitation.")]
        [Display(Name = "AcceptRegret")]
        public string AcceptRegret { get; set; }

        [Range(0, 10, ErrorMessage = "Must be between 0 and 10")]
        [Display(Name = "Number of Kids Meals Needed(Kids Under 12)", Description ="description stuff")]
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