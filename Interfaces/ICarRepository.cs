using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sample.Dto.Cars;
using sample.Dto.Transactions;
using sample.Models;

namespace sample.Interfaces
{
    public interface ICarRepository
    {
        public List<CarDto> GetAllCars();
        public CarDto GetById(int id);
        public Car RegisterCar(CreateCarDto carDto);
        public CarDto UpdateCar(int id, CreateCarDto carDto);
        public CarDto DeleteCar(int id);
        public void AddCarTransaction(AddTransactionDto transactionDto);
    }
}