using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _CarDal;
        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }
        public List<Car> GetAll()   
        {
            return _CarDal.GetAll();
        }
        public List<Car> GetCarsByBrandId(int id)
        {
            return _CarDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _CarDal.GetAll(c => c.ColorId == id);
        }
       
        public void Add(Car car)
        {
            if (car.DailyPrice >0 && car.CarName.Length > 2)
            {
                _CarDal.Add(car);
            }
        }
    }
}