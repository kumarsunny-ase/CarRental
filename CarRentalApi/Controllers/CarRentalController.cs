using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CarRentalApi.Models;
using CarRentalApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CarRentalApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarRentalController : Controller
    {
        private readonly ICarRentalService _carRentalService;
        public CarRentalController(ICarRentalService carRentalService)
        {
            _carRentalService = carRentalService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CarRental>> GetAllRentalPrice([FromQuery] decimal days)
        {
            var result = _carRentalService.GetAllCarRentals(days);
            return Ok(result);
        }
    }
}