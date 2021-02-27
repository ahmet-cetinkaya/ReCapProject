using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (var context = new ReCapProjectContext())
            {
                var result = from p in context.Cars
                    join b in context.Brands
                        on p.BrandId equals b.Id
                    join c in context.Colors
                        on p.ColorId equals c.Id
                    select new CarDetailDto
                    {
                        CarName = p.Name,
                        BrandName = b.Name,
                        ColorName = c.Name,
                        DailyPrice = p.DailyPrice
                    };
                return result.ToList();
            }
        }
    }
}