using Core.DataAccess;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailsDto> GetCarsDetails();
    }
}