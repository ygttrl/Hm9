using Business.Abstruct;
using DataAccess.Abstruct;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandservice
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }

        public Brand Get(int id)
        {
           return  _brandDal.Get(x => x.Id==id);
        }

        public List<Brand> GetAll(int brandId)
        {
            return _brandDal.GetAll(x => x.Id == brandId);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

       
    }
}
