using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Entities;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Brand
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { Name="Toyota" });
            //var brand = brandManager.Get(10);
            //brand.Name = "Toyotaa";
            // brandManager.Update(brand);
            //brandManager.Delete(brand);
            //foreach (var brands in brandManager.GetAll())
            //{
            //    Console.WriteLine($"{brands.Id} -- {brands.Name} ");
            //}
            // Console.WriteLine(brandManager.Get(9).Id +" "+brandManager.Get(9).Name );

            #endregion

            #region Color
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color {Name="Yellow" });
            //var color = colorManager.Get(10);
            //color.Name = "Dark Yellow";
            //colorManager.Update(color);
            //colorManager.Delete(color);

            //foreach (var colors in colorManager.GetAll())
            //{
            //    Console.WriteLine($"{colors.Id} -- {colors.Name}");
            //}

            //Console.WriteLine(colorManager.Get(10).Id +" "+colorManager.Get(10).Name ); 
            #endregion

            #region Car
            //CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { BrandId=1,ColorId=1,Description="i 30",ModelYear=DateTime.Now,DailyPrice=180000 });
            //var car = carManager.Get(26);
            //car.Description = "i 30sw";
            //carManager.Update(car);
            //carManager.Delete(car);

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine($"{item.Id} -- {item.ColorId} -- {item.BrandId} -- {item.Description} -- {item.ModelYear} -- {item.DailyPrice}");
            //} 
            #endregion

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCatDetails())
            {
                Console.WriteLine($"{item.BrandName} -- {item.CarName} -- {item.ColorName} -- {item.DailyPrice} ");
            }

        }
    }
}
