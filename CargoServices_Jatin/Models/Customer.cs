using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CargoServices_Jatin.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public List<Booking> Bookings { get; set; }
        public List<Job> Jobs { get; set; }
    }
}