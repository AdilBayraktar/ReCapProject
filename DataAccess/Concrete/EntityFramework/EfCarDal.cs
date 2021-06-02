using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,CarsDbContext> ,ICarDal
    {
        public  List<CarDetailsDto> GetCarsDetails()
        {
            using (CarsDbContext context = new CarsDbContext())
            {
                var result = from c in context.Car
                             join co in context.Color
                             on c.ColorId equals co.ColorId
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             select new CarDetailsDto
                             {
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 CarId = c.CarId
                             };

                return result.ToList();
            }
        }

    }
}
