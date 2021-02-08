using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 120, ModelYear = 2010, Description = "a"},
                new Car{Id = 2, BrandId = 1, ColorId = 4, DailyPrice = 550, ModelYear = 2012, Description = "b"},
                new Car{Id = 3, BrandId = 2, ColorId = 5, DailyPrice = 750, ModelYear = 2015, Description = "c"},
                new Car{Id = 4, BrandId = 2, ColorId = 2, DailyPrice = 350, ModelYear = 2005, Description = "d"},
                new Car{Id = 5, BrandId = 3, ColorId = 1, DailyPrice = 1000, ModelYear = 2020, Description = "e"},
            };
        }

        public Car GetById(int Id)
        {
            return _cars.SingleOrDefault(c => c.Id == Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car Car)
        {
            _cars.Add(Car);
        }

        public void Update(Car Car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.Id == Car.Id);
            CarToUpdate.BrandId = Car.BrandId;
            CarToUpdate.ColorId = Car.ColorId;
            CarToUpdate.ModelYear = Car.ModelYear;
            CarToUpdate.DailyPrice = CarToUpdate.DailyPrice;
            CarToUpdate.Description = CarToUpdate.Description;
        }

        public void Delete(Car Car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.Id == Car.Id);
            _cars.Remove(CarToDelete);
        }
    }
}