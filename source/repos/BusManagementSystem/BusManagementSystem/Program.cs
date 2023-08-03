using BusManagementSystem.Entities;
using BusManagementSystem.Repository;
using System.Collections.Generic;
using System;

namespace BusManagementSystem
{
    class Program
    {
        

        static void Main(string[] args)
        {
            BusRepository busRepository = new BusRepository();
            List<Trip> buses = new List<Trip>();

            var bus = new Trip
            {
                Model = "Mazda",
                RegistrationNumber = "ASFGHJBH",
                PlateNumber = "AERGGH12",
                Capacity = 30,
                AvailabilityStatus = true,
                BusType = Enums.BusType.FirstClass,
                TripStatus = true

            };

            var bus1 = new Trip
            {
                Model = "Toyota",
                RegistrationNumber = "ASGRHJGK",
                PlateNumber = "AERDFHGHMJ",
                Capacity = 45,
                AvailabilityStatus = true,
                BusType = Enums.BusType.BussinessClass,
                TripStatus = false
            };


            var bus2 = new Trip
            {
                Model = "Corolla",
                RegistrationNumber = "WTGGHGHHG",
                PlateNumber = "ERTYUGH23",
                Capacity = 27,
                AvailabilityStatus = true,
                BusType = Enums.BusType.Economy,
                TripStatus = true
            };

            var bus3 = new Trip
            {
                
                Model = "Camry007 ",
                RegistrationNumber = "WEFHGGHY1234",
                PlateNumber = "WRTFFH234",
                Capacity = 30,
                AvailabilityStatus = false,
                BusType = Enums.BusType.FirstClass,
                TripStatus = false

                
            };

            //buses.Add(bus);
            //buses.Add(bus1);
            //buses.Add(bus2);
            //buses.Add(bus3);
            //busRepository.Create(buses);
            //busRepository.DeleteBus(3);
            //busRepository.Update(7,bus3);
            var result = busRepository.GetAll();
            Console.WriteLine(result);


            
            
            //foreach (var item in buses)
            //{
            //    Console.WriteLine($"{item.Model} {item.RegistrationNumber} {item.PlateNumber} {item.Capacity} {item.BusType} {item.TripStatus}");
            //}

            //var newbus = busRepository.Create(bus);
            //Console.WriteLine($"BusId{newbus.Id} Model{newbus.Model} ");


        }
    }
}
