using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalsManager : IRentalsService
    {

        IRentalsDal _rentalsDal;

        public RentalsManager(IRentalsDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }

        public IResult Add(Rentals entity)
        {
            _rentalsDal.Add(entity);
            return new SuccessResult(Massages.Added);
        }

        public IResult Delete(Rentals entity)
        {
            _rentalsDal.Delete(entity);
            return new SuccessResult(Massages.Deleted);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalsDal.GetAll());
        }

        public IDataResult<Rentals> GetById(int id)
        {
            return new SuccessDataResult<Rentals>(_rentalsDal.Get(r => r.Id == id));
        }

        public IResult Update(Rentals entity)
        {
            _rentalsDal.Update(entity);
            return new SuccessResult(Massages.Updated);
        }
    }
}
