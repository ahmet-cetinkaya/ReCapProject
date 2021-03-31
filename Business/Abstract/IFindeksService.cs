using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFindeksService
    {
        IDataResult<Findeks> GetById(int id);

        IDataResult<Findeks> GetByCustomerId(int customerId);

        IDataResult<List<Findeks>> GetAll();

        IResult Add(Findeks findeks);

        IResult Update(Findeks findeks);

        IResult Delete(Findeks findeks);

        IDataResult<Findeks> CalculateFindeksScore(Findeks findeks);
    }
}