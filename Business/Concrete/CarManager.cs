using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstracts;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService , IBusinessService<Car>
    {
        private ICarDal _CarDal;
        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }
        public IDataResult<List<Car>> GetAll()   
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Massages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(),Massages.Listed);
        }
        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(c => c.BrandId == id),Massages.Listed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(c => c.ColorId == id),Massages.Listed);
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice >0 && car.CarName.Length > 2)
            {
                 _CarDal.Add(car);
                return new SuccessResult(Massages.Added);
            }
            return new ErrorResult(Massages.CarNameInvalid);
        }

        public IResult Delete(Car car)
        {
            _CarDal.Delete(car);
            return new SuccessResult(Massages.Deleted);
        }

        public IResult Update(Car car)
        {
            _CarDal.Update(car);
            return new SuccessResult(Massages.Updated);
        }

        public IDataResult <Car> GetById(int id)
        {

            return new SuccessDataResult<Car>(_CarDal.Get(c => c.CarId == id),Massages.Listed);
        }

        public List<CarDetailsDto> GetCarsDetails()
        {
            return _CarDal.GetCarsDetails();
        }
    }
}