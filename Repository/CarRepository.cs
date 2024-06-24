using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sample.Data;
using sample.Dto.Cars;
using sample.Dto.Transactions;
using sample.Interfaces;
using sample.Mappers;
using sample.Models;

namespace sample.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly DataContext _context;
        public CarRepository(DataContext context)
        {
            _context = context;
        }

        public void AddCarTransaction(AddTransactionDto transactionDto)
        {
            _context.Transactions.Add(transactionDto.ToModel());
            _context.SaveChanges();
        }

        public CarDto DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDto> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public CarDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Car RegisterCar(CreateCarDto carDto)
        {
            var carModel = carDto.ToCarModel();
            var car = _context.Cars.Add(carModel);
            _context.SaveChanges();
            return carModel;
        }

        public CarDto UpdateCar(int id, CreateCarDto carDto)
        {
            throw new NotImplementedException();
        }
    }
}