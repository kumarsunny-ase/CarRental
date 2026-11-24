using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalApi.Models;

namespace CarRentalApi.Services
{
    public interface ICarRentalService
    {
        IEnumerable<CarRental> GetAllCarRentals(decimal days);
    }
}