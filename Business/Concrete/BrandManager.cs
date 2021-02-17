using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
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
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<Brand> GetById(int id)
        {
            // Debug and Conditions

            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == id));
        }

        public IDataResult<List<Brand>> GetAll()
        {
            // Debug and Conditions

            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IResult Add(Brand brand)
        {
            ValidationTool.Validate(new CarValidator(), new ValidationContext<Brand>(brand));
            // Debug and Conditions

            _brandDal.Add(brand);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Update(Brand brand)
        {
            // Debug and Conditions

            _brandDal.Update(brand);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Brand brand)
        {
            // Debug and Conditions

            _brandDal.Delete(brand);
            return new SuccessResult(Messages.CarDeleted);
        }
    }
}