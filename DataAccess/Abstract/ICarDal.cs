using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        Car GetById(int id);

        List<Car> GetAll();

        void Add(Car product);

        void Update(Car product);

        void Delete(Car product);
    }
}