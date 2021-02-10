using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstruct
{
    public interface IBrandservice
    {
        List<Brand> GetAll(int brandId);

        List<Brand> GetAll();

        void Add(Brand brand);

        void Update(Brand brand);

        void Delete(Brand brand);

        Brand Get(int id);

    }
}
