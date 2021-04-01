using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<Rental> GetById(int id);

        IDataResult<List<Rental>> GetAll();

        IDataResult<List<Rental>> GetAllByCarId(int carId);

        IResult Add(Rental rental);

        IResult Update(Rental rental);

        IResult Delete(Rental rental);

        IResult CheckReturnDateByCarId(int carId);

        IResult IsRentable(Rental rental);

        IResult CheckFindeksScoreSufficiency(Rental rental);
    }
}