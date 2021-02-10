using Entity.Dtos;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstruct
{
    public interface ICarService
    {
        List<Car> GetAll(int carId);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        Car Get(int id);
        List<CarDetailDto> GetCatDetails();
    }
}
