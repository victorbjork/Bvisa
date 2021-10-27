using DockSiiide.Areas.Identity.Data;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DockSiiide.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public Room Room { get; set; }
        public DateTime StartBooking { get; set; }
        public DateTime EndBooking { get; set; }
        public DateTime TimeOfBooking { get; set; }
        public double BookingPrice { get; set; }
        public Booking()
        {
            TimeOfBooking = DateTime.Now;
        }
    }
}
