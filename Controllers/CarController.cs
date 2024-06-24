using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sample.Data;
using sample.Dto.Cars;
using sample.Dto.Transactions;
using sample.Interfaces;

namespace sample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository repo;
        public CarController(ICarRepository repository){
            repo = repository;
        }

        [HttpPost]
        public IActionResult RegisterCar([FromBody] CreateCarDto createCarDto){
            var car = repo.RegisterCar(createCarDto);
            return Ok(car);
        }

        [HttpPost("Buy_Car")]
        public IActionResult BuyCar([FromBody] AddTransactionDto transactionDto){
            repo.AddCarTransaction(transactionDto);
            return Ok("Car Bought Successfully");
        }

    }
}