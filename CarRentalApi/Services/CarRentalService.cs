using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalApi.Models;

namespace CarRentalApi.Services
{
    public class CarRentalService : ICarRentalService
    {
        private readonly List<CarRental> _carRental = new()
        {
          new CarRental {Provider="AutoRent", CarName="BMW 1 Series", DailyPrice=65m, Discount=10m},  
          new CarRental {Provider="CityDrive", CarName="VW Golf", DailyPrice=45m, Discount=5m}, 
          new CarRental {Provider="FastCar", CarName="Audi A3", DailyPrice=75m, Discount=15m},
          new CarRental {Provider="EasyMove", CarName="Opel Astra", DailyPrice=40m, Discount=0m}
        };
        public IEnumerable<CarRental> GetAllCarRentals(decimal days)
        {
            var result = _carRental.Select(p => new CarRental
            {
                Provider  = p.Provider,
                CarName = p.CarName,
                DailyPrice = p.DailyPrice,
                Discount = p.Discount,

                TotalPrice = CalculatedTotalPrice(p.DailyPrice, p.Discount, days) 
            }).OrderBy(x => x.TotalPrice);

            return result;
        }

        private decimal CalculatedTotalPrice(decimal dailyPrice, decimal discount, decimal days)
        {
            decimal totalPrice = (dailyPrice * days);

            // if (days >= 7)
            // {             
            //     totalPrice -= totalPrice * (discount / 100m);
            // }
            totalPrice -= totalPrice * (discount / 100m);
            return totalPrice;
        }
    }
}