using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>{
            new Car{CarId = 1, BrandId = 1, ColorId = 1 , ModelYear = "2015" , Description = "BMW" , DailyPrice = 75000},
            new Car{CarId = 2, BrandId = 1, ColorId = 2 , ModelYear = "2018" , Description = "BMW" , DailyPrice = 95000},
            new Car{CarId = 3, BrandId = 2, ColorId = 3 , ModelYear = "2020" , Description = "Audi" , DailyPrice = 125000},
            new Car{CarId = 4, BrandId = 2, ColorId = 4 , ModelYear = "2020" , Description = "Audi" , DailyPrice = 115000},
            new Car{CarId = 5, BrandId = 3, ColorId = 5 , ModelYear = "2009" , Description = "Mazda" , DailyPrice = 65000}
        };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carUpdate.CarId = car.CarId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
        }
    }
}