using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetById(int id);

        IDataResult<List<User>> GetAll();

        IResult Add(User user);

        IResult Update(User user);

        IResult Delete(User user);

        IDataResult<List<OperationClaim>> GetClaims(User user);

        IDataResult<User> GetByMail(string email);
    }
}