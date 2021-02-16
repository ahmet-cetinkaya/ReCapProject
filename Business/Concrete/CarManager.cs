using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Concrete.Utilities;
using Business.Concrete.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;

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

            return _carDal.Get(p => p.Id == id);
        }

        public List<Car> GetAll()
        {
            // Debug and Conditions

            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            // Debug and Conditions

            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            // Debug and Conditions

            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            // Debug and Conditions

            return _carDal.GetAll(p => p.ColorId == id);
        }

        public void Add(Car car)
        {
            ValidationTool.Validate(new CarValidator(), new ValidationContext<Car>(car));
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