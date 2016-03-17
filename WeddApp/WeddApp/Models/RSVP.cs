using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WeddApp.Models
{
    public class RSVP
    {
        public int ID { get; set; }

        public int NumAttending { get; set; }

        public string Name { get; set; }

        public bool Accepts { get; set; }

        public bool Declines { get; set; }

        public int NumKidsMeal { get; set; }

        public string Comments { get; set; }
    }

    public class RSVPDBContext : DbContext
    {
        public DbSet<RSVP> RSVPs { get; set; }
    }
}