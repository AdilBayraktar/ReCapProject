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

            carManager.Add(new Car { CarId = 1, CarName = "BMW", DailyPrice = 158000, CarDescription = "BMW X6", ModelYear = "2020" });
            carManager.Add(new Car { CarId = 2, CarName = "Kia", DailyPrice = 142000, CarDescription = "Kia Sportag", ModelYear = "2018" });
            carManager.Add(new Car { CarId = 3, CarName = "Audi", DailyPrice = 215000, CarDescription = "Audi A8", ModelYear = "2021" });
            carManager.Add(new Car { CarId = 4, CarName = "Ford", DailyPrice = 139000, CarDescription = "Ford Focus", ModelYear = "2018" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
                Console.WriteLine(car.CarDescription);
            }

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            //carManager.Add(new Car { Description = "Kia" });

            //Console.WriteLine("----------After Adding-----------");

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
            //Console.WriteLine("-------------------------------------------------");



        }
    }
}
