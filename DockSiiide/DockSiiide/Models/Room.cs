using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DockSiiide.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string RoomName { get; set; }
        public decimal WholeDayPrice { get; set; }
        public decimal HalfDayPrice { get; set; }
        public decimal HourPrice { get; set; }

    }
}
