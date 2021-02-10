using Business.Abstruct;
using DataAccess.Abstruct;
using Entity.Dtos;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public Car Get(int id)
        {
          return  _carDal.Get(x => x.Id == id);
        }

        public List<Car> GetAll(int brandId)
        {
            return _carDal.GetAll(x => x.BrandId== brandId);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCatDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
