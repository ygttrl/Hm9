using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstruct
{
    public interface IColorService
    {
        List<Color> GetAll(int brandId);

        List<Color> GetAll();

        void Add(Color brand);

        void Update(Color brand);

        void Delete(Color brand);

        Color Get(int id);
    }
}
