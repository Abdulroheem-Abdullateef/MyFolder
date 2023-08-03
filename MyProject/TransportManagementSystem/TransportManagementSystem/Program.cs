using System;
using TransportManagementSystem.Dtos;
using TransportManagementSystem.Entities;
using TransportManagementSystem.Implementations.Services;

namespace TransportManagementSystem
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
               BusServices service = new BusServices();
             var bus = new CreateRequestBusModel
             {
                BusClass = Enums.BusClass.BusinessClass,
                PlateNumber = "OYO1234",
                RegistrationNumber = "74FEECA",
                Model = "Corolla",
                EngineNumber = "QWERTY1234"
           
             };
            var b = service.CreateBus(bus);
            Console.WriteLine(b);

        }
    }
}
