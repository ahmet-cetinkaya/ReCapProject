using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda.";

        public static string CarNameInvalid = "Araç ismi geçersiz.";
        public static string CarsListed = "Araçlar listelendi";
        public static string CarAdded = "Araçlar eklendi.";
        public static string CarUpdated = "Araç güncellendi.";
        public static string CarDeleted = "Araç silindi.";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserDeleted = "Kullanıcı silindi.";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerDeleted = "Müşteri silindi.";

        public static string RentalAdded = "Kiralama işlemi eklendi.";
        public static string RentalUpdated = "Kiralama işlemi güncellendi.";
        public static string RentalDeleted = "Kiralama işlemi silindi.";
        public static string RentalUndeliveredCar = "Araç henüz teslim edilmedi.";
    }
}