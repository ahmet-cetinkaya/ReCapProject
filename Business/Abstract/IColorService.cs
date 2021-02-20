using System;
using System.Collections.Generic;
using System.Text;
using Business.Concrete.Utilities;
using Business.Concrete.Validation.FluentValidation;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using FluentValidation;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<Color> GetById(int id);

        IDataResult<List<Color>> GetAll();

        IResult Add(Color color);

        IResult Update(Color color);

        IResult Delete(Color color);
    }
}