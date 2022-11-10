using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoMute.Web.Models
{
    public class CarPool
    {
        [Required]
        public string Destination { get; set; }
        [Required]
        public string Origin { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime DepatureTime { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime ExpectedArrival { get; set; }
        public string DaysAvailable { get; set; }
        [Required]
        public int AvailableSeats { get; set; }
        [Required]
        public string Leader { get; set; }
        public string Notes { get; set; }
    }
}