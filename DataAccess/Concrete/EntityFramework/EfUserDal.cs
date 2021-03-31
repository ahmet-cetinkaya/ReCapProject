using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapProjectContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new ReCapProjectContext())
            {
                var result = from operationClaim in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on operationClaim.Id equals userOperationClaim.OperationClaimId
                    where userOperationClaim.UserId == user.Id
                    select new OperationClaim {Id = operationClaim.Id, Name = operationClaim.Name};
                return result.ToList();
            }
        }

        public UserDetailDto GetUserDetail(string userMail)
        {
            using (var context = new ReCapProjectContext())
            {
                var result =
                    (from u in context.Users
                        join c in context.Customers
                            on u.Id equals c.UserId
                        where u.Email == userMail
                        select new UserDetailDto
                        {
                            Id = u.Id,
                            CustomerId = c.Id,
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            Email = u.Email,
                            CompanyName = c.CompanyName
                        }).First();
                return result;
            }
        }
    }
}