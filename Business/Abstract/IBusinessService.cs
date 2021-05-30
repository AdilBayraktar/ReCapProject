using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBusinessService<T>
    {
        List<T> GetAll();

        T GetById(int id);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}