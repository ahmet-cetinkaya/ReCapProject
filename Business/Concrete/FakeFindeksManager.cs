using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FakeFindeksManager : IFindeksService
    {
        private readonly IFindeksDal _findeksDal;

        public FakeFindeksManager(IFindeksDal findeksDal)
        {
            _findeksDal = findeksDal;
        }

        [SecuredOperation("findeks.getbyid,moderator,admin")]
        public IDataResult<Findeks> GetById(int id)
        {
            return new SuccessDataResult<Findeks>(_findeksDal.Get(f => f.Id == id));
        }

        [SecuredOperation("user")]
        public IDataResult<Findeks> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<Findeks>(_findeksDal.Get(f => f.CustomerId == customerId));
        }

        [SecuredOperation("findeks.getall,moderator,admin")]
        public IDataResult<List<Findeks>> GetAll()
        {
            return new SuccessDataResult<List<Findeks>>(_findeksDal.GetAll());
        }

        public IResult Add(Findeks findeks)
        {
            var newFindeks = CalculateFindeksScore(findeks).Data;
            _findeksDal.Add(newFindeks);
            return new SuccessResult(Messages.BrandAdded);
        }

        [SecuredOperation("findeks.update,moderator,admin")]
        public IResult Update(Findeks findeks)
        {
            var newFindeks = CalculateFindeksScore(findeks).Data;
            _findeksDal.Update(newFindeks);
            return new SuccessResult(Messages.BrandAdded);
        }

        [SecuredOperation("findeks.delete,moderator,admin")]
        public IResult Delete(Findeks findeks)
        {
            _findeksDal.Delete(findeks);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IDataResult<Findeks> CalculateFindeksScore(Findeks findeks)
        {
            findeks.Score = (short) new Random().Next(0, 1901);
            return new SuccessDataResult<Findeks>(findeks);
        }
    }
}