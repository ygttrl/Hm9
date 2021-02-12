using Core.Utilities.Result;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstruct
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll(int brandId);

       IDataResult<List<Color>> GetAll();

        IResult Add(Color brand);

        IResult Update(Color brand);

        IResult Delete(Color brand);

        IDataResult<Color> Get(int id);
    }
}
