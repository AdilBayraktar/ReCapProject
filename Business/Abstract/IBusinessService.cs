using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBusinessService<T>
    {
        IDataResult<List<T>> GetAll();

        IDataResult <T> GetById(int id);

        IResult Add(T entity);

        IResult Delete(T entity);

        IResult Update(T entity);
    }
}