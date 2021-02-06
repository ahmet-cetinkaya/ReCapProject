using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public Car GetById(int id)
        {
            // Debug and Conditions

            return _carDal.GetById(id);
        }

        public List<Car> GetAll()
        {
            // Debug and Conditions

            return _carDal.GetAll();
        }

        public void Add(Car car)
        {
            // Debug and Conditions

            _carDal.Add(car);
        }

        public void Update(Car car)
        {
            // Debug and Conditions

            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            // Debug and Conditions

            _carDal.Delete(car);
        }
    }
}