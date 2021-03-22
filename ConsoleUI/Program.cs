using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //carTest();
            //userTest();
            //customerUser();
            //rentalTest();
        }

        //private static void rentalTest()
        //{
        //    var rentalManager = new RentalManager(new EfRentaldal());
        //    var rental = new Rental
        //    {
        //        //Id = 3,
        //        CarId = 4,
        //        CustomerId = 3,
        //        RentDate = DateTime.Now,
        //        ReturnDate = null
        //    };
        //    var result = rentalManager.Add(rental);
        //    if (!result.Success) Console.WriteLine(result.Message);
        //    //rentalManager.Update(rental);
        //    //rentalManager.Delete(rental);
        //    rentalManager.GetAll().Data.ForEach(r => Console.WriteLine(r.CarId + " " + r.RentDate));
        //}

        private static void customerUser()
        {
            var customerManager = new CustomerManager(new EfCustomerDal());
            var customer = new Customer
            {
                //Id = 2,
                UserId = 2,
                CompanyName = "AhmetCetinkaya"
            };
            customerManager.Add(customer);
            //customerManager.Update(customer);
            //customerManager.Delete(customer);
            customerManager.GetAll().Data.ForEach(c => Console.WriteLine(c.Id + " " + c.UserId + " " + c.CompanyName));
        }

        private static void userTest()
        {
            var userManager = new UserManager(new EfUserDal());
            //User user = new User
            //{
            //    FirstName = "Ahmet",
            //    LastName = "Çetinkaya",
            //    Email = "ahmetcetinkaya4@outlook.com",
            //    Password = "testpassword"
            //};
            //userManager.Add(user);
            //userManager.Update(user);
            //userManager.Delete(user);
            userManager.GetAll().Data.ForEach(u => Console.WriteLine(u.FirstName));
        }

        private static void carTest()
        {
            var carManager = new CarManager(new EfCarDal());
            //Car car = new Car
            //{
            //    Name = "iX",
            //    BrandId = 1,
            //    ColorId = 2,
            //    ModelYear = 2020,
            //    DailyPrice = 500,
            //    Description = "Yeni teslim alındı."
            //};
            //carManager.Add(car);
            //carManager.Update(car);
            //carManager.Delete(car);
            carManager.GetAll().Data.ForEach(p => Console.WriteLine(p.Name));
            carManager.GetCarDetails().Data.ForEach(p =>
                Console.WriteLine("{0} {1} {2} {3}", p.CarName, p.BrandName, p.ColorName, p.DailyPrice));
        }
    }
}