using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sample.Dto.Cars;
using sample.Models;

namespace sample.Mappers
{
    public static class CarMapper
    {
        public static Car ToCarModel(this CreateCarDto carDto){
            return new Car{
                Name = carDto.Name,
                Brand = carDto.Brand,
            };
        }
        public static CarDto ToCarDtoFromCarModel(this Car car){
            return new CarDto{
                Name = car.Name,
                Brand = car.Brand,
            };
        }
    }
}