﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<Car> GetById(int id);

        IDataResult<List<Car>> GetAll();

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IDataResult<List<Car>> GetCarsByBrandId(int id);

        IDataResult<List<Car>> GetCarsByColorId(int id);

        IResult Add(Car car);

        IResult Update(Car car);

        IResult Delete(Car car);
    }
}