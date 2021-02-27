using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<Rental> GetById(int id);

        IDataResult<List<Rental>> GetAll();

        IResult Add(Rental rental);

        IResult Update(Rental rental);

        IResult Delete(Rental rental);
    }
}