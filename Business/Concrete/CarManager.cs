using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Concrete.Utilities;
using Business.Concrete.Validation.FluentValidation;
using Business.Constants;
using Core.Utilities.Results;
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

        public IDataResult<Car> GetById(int id)
        {
            // Debug and Conditions

            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Car>> GetAll()
        {
            // Debug and Conditions

            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            // Debug and Conditions

            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            // Debug and Conditions

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            // Debug and Conditions

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }

        public IResult Add(Car car)
        {
            ValidationTool.Validate(new CarValidator(), new ValidationContext<Car>(car));
            // Debug and Conditions

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Update(Car car)
        {
            // Debug and Conditions

            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            // Debug and Conditions

            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }
    }
}