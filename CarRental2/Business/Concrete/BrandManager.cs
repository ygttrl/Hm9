﻿using Business.Abstruct;
using Business.Constants;
using Core.Utilities.Result;
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

        public IResult Add(Brand brand)
        {
            if (brand==null)
            {
                return new ErrorResult();
            }
            _brandDal.Add(brand);
            return new SuccessResult();
        }

        public IResult Delete(Brand brand)
        {
            if (brand==null)
            {
                return new ErrorResult(Message.ErrorMasage);
            }

            _brandDal.Delete(brand);
            return new SuccessResult();
        }

        public IResult Update(Brand brand)
        {
            if (brand==null)
            {
                return new ErrorResult();
            }
            _brandDal.Update(brand);
            return new ErrorResult();
        }

        public IDataResult<Brand> Get(int id)
        {
            if (id<=0)
            {
                return new ErrorDataResult<Brand>(Message.ErrorMasage);
            }
            return new SuccessDataResult<Brand>(_brandDal.Get(x => x.Id == id), Message.ErrorMasage);
        }

        public IDataResult<List<Brand>> GetAll(int brandId)
        {
            if (brandId<=0)
            {
                return new ErrorDataResult<List<Brand>>(Message.ErrorMasage);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(x => x.Id == brandId),Message.SuccesMassage);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Message.SuccesMassage);
        }

       
    }
}
