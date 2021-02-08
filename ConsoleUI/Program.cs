using System;
using Business.Concrete;
using Business.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car newCar = new Car
            { Name = "M3", BrandId = 1, ColorId = 2, ModelYear = 2019, DailyPrice = -10, Description = "f" };

            carManager.Add(newCar);
            carManager.GetAll().ForEach(p => Console.WriteLine(p.Name));
        }
    }
}