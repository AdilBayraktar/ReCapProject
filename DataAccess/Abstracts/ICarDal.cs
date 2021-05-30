﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface ICarDal : IEntityRespository<Car>
    {
        List<CarDetailsDto> GetCarsDetails();
    }
}