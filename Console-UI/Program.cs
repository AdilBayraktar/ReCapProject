using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console_UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var item in carManager.GetCarsDetails())
            {
                Console.WriteLine(item.CarName + "/" + item.BrandName + "/" + item.ColorName );
            }


            //carManager.Add(new Car { CarId = 1, BrandId = 1, ColorId = 1, CarName = "BMW", DailyPrice = 158000, CarDescription = "BMW X6", ModelYear = "2020" });
            //carManager.Add(new Car { CarId = 2, BrandId = 2, ColorId = 2, CarName = "Kia", DailyPrice = 142000, CarDescription = "Kia Sportag", ModelYear = "2018" });
            //carManager.Add(new Car { CarId = 3, BrandId = 3, ColorId = 3, CarName = "Audi", DailyPrice = 215000, CarDescription = "Audi A8", ModelYear = "2021" });
            //carManager.Add(new Car { CarId = 4, BrandId = 4, ColorId = 4, CarName = "Ford", DailyPrice = 139000, CarDescription = "Ford Focus", ModelYear = "2018" });
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName);
            //    Console.WriteLine(car.CarDescription);
            //}
            //colorManager.Add(new Color { ColorId = 1, ColorName = "White" });
            //colorManager.Add(new Color { ColorId = 2, ColorName = "Red" });
            //colorManager.Add(new Color { ColorId = 3, ColorName = "Black" });
            //colorManager.Add(new Color { ColorId = 4, ColorName = "Green" });

            //foreach (var item in colorManager.GetAll())
            //{
            //    Console.WriteLine(item.ColorName);
            //}
            //Console.WriteLine("......................................");

            //brandManager.Add(new Brand { BrandId = 1, BrandName = "BMW" });
            //brandManager.Add(new Brand { BrandId = 2, BrandName = "Kia" });
            //brandManager.Add(new Brand { BrandId = 3, BrandName = "Audi" });
            //brandManager.Add(new Brand { BrandId = 4, BrandName = "Ford" });
            //brandManager.Add(new Brand { BrandId = 5, BrandName = "Mercedes" });

            //foreach (var item in brandManager.GetAll())
            //{
            //    Console.WriteLine(item.BrandName);
            //}
            //Console.WriteLine("......................................");


            //carManager.Update(new Car { CarId = 1, BrandId = 5, ColorId = 3, CarName = "Mercedes", DailyPrice = 258000, CarDescription = "Mercedes E1582", ModelYear = "2021" });

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.CarDescription);
            //}








        }
    }
}
