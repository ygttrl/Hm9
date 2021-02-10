using Business.Abstruct;
using DataAccess.Abstruct;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }

        public Color Get(int id)
        {
            return _colorDal.Get(x => x.Id == id);
        }

        public List<Color> GetAll(int colorId)
        {
            return _colorDal.GetAll(x => x.Id==colorId);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

       
    }
}
