using Business.Concrete;
using Core.Utilities.Results.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Console_UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = carManager.GetAll();
            var colors = colorManager.GetAll();
            var brands = brandManager.GetAll();
            var users = userManager.GetAll();
            var customers = customerManager.GetAll();

            if (users.Success == true)
            {
                foreach (var item in users.Data)
                {
                    Console.WriteLine(item.FirstName);
                }
            }
            else
            {
                Console.WriteLine(result.Massage);
            }

            //AddingUser(userManager, users);

            //CarsAdding(carManager, result);

            //ColorsAdding(colorManager, colors);

            //BrandAdding(brandManager, brands);

        }

        private static void AddingUser(UserManager userManager, IDataResult<List<User>> users)
        {
            userManager.Add(new User { Id = 1, FirstName = "Ahmet", LastName = "Aslan", Email = "ahmetaslan@gmail.com", Password = "0000" });
            userManager.Add(new User { Id = 2, FirstName = "Akif", LastName = "Altun", Email = "akifaltun@gmail.com", Password = "0000" });
            userManager.Add(new User { Id = 3, FirstName = "Adem", LastName = "Kahraman", Email = "ademkahraman@gmail.com", Password = "0000" });
            userManager.Add(new User { Id = 4, FirstName = "Fatih", LastName = "Servi", Email = "fatihservi@gmail.com", Password = "0000" });
            userManager.Add(new User { Id = 5, FirstName = "Adil", LastName = "Bayraktar", Email = "adilbayraktar1997@gmail.com", Password = "0000" });
            if (users.Success == true)
            {
                foreach (var item in users.Data)
                {
                    Console.WriteLine(item.FirstName + "" + item.LastName);
                }
            }
            else
            {
                Console.WriteLine(users.Massage);
            }
        }

        private static void BrandAdding(BrandManager brandManager, IDataResult<List<Brand>> brands)
        {
            brandManager.Add(new Brand { BrandId = 1, BrandName = "BMW" });
            brandManager.Add(new Brand { BrandId = 2, BrandName = "Kia" });
            brandManager.Add(new Brand { BrandId = 3, BrandName = "Audi" });
            brandManager.Add(new Brand { BrandId = 4, BrandName = "Ford" });
            brandManager.Add(new Brand { BrandId = 5, BrandName = "Mercedes" });
            brandManager.Add(new Brand { BrandId = 6, BrandName = "Fiat"});

            if (brands.Success == true)
            {
                foreach (var item in brands.Data)
                {
                    Console.WriteLine(item.BrandName);
                }
            }
            else
            {
                Console.WriteLine(brands.Massage);
            }
        }

        private static void ColorsAdding(ColorManager colorManager, IDataResult<List<Color>> colors)
        {
            colorManager.Add(new Color { ColorId = 1, ColorName = "White" });
            colorManager.Add(new Color { ColorId = 2, ColorName = "Red" });
            colorManager.Add(new Color { ColorId = 3, ColorName = "Black" });
            colorManager.Add(new Color { ColorId = 4, ColorName = "Green" });

            if (colors.Success == true)
            {
                foreach (var item in colors.Data)
                {
                    Console.WriteLine(item.ColorName);
                }
            }
            else
            {
                Console.WriteLine(colors.Massage);
            }
        }

        private static void CarsAdding(CarManager carManager, IDataResult<List<Car>> result)
        {
            carManager.Add(new Car { CarId = 1, BrandId = 1, ColorId = 1, CarName = "bmw", DailyPrice = 158000, CarDescription = "bmw x6", ModelYear = "2020" });
            carManager.Add(new Car { CarId = 2, BrandId = 2, ColorId = 2, CarName = "kia", DailyPrice = 142000, CarDescription = "kia sportag", ModelYear = "2018" });
            carManager.Add(new Car { CarId = 3, BrandId = 3, ColorId = 3, CarName = "audi", DailyPrice = 215000, CarDescription = "audi a8", ModelYear = "2021" });
            carManager.Add(new Car { CarId = 4, BrandId = 4, ColorId = 4, CarName = "ford", DailyPrice = 139000, CarDescription = "ford focus", ModelYear = "2018" });

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName);
                    Console.WriteLine(car.CarDescription);
                }
            }
            else
            {
                Console.WriteLine(result.Massage);
            }
        }
    }
}
