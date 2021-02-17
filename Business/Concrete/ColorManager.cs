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
using FluentValidation;
using FluentValidation.Results;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IDataResult<Color> GetById(int id)
        {
            // Debug and Conditions

            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Color>> GetAll()
        {
            // Debug and Conditions

            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IResult Add(Color color)
        {
            IDataResult<ValidationResult> validationResult = ValidationTool.Validate(new CarValidator(), new ValidationContext<Color>(color));
            if (validationResult.Success == false)
            {
                return new ErrorDataResult<ValidationResult>(validationResult.Data);
            }
            // Debug and Conditions

            _colorDal.Add(color);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Update(Color color)
        {
            // Debug and Conditions

            _colorDal.Update(color);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Color color)
        {
            // Debug and Conditions

            _colorDal.Delete(color);
            return new SuccessResult(Messages.CarDeleted);
        }
    }
}