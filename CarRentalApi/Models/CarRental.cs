using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApi.Models
{
    public class CarRental
    {
        public string Provider { get; set; } = string.Empty;
        public string CarName { get; set; } = string.Empty;
        public decimal DailyPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}