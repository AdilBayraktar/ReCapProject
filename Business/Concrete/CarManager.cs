using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : IBusinessService
    {
        private ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public void Add(Car car)
        {
            _CarDal.Add(car);
        }

        public void Delete(Car car)
        {
            _CarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public List<Car> GetById(int categoryId)
        {
            return _CarDal.GetById(categoryId);
        }

        public void Update(Car car)
        {
            _CarDal.Update(car);
        }
    }
}