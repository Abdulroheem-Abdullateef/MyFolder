using BusManagementSystem.Entities;
using BusManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem
{
    class Menu
    {
        protected static BusService _busService = new BusService();

        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("Enter 1 to Register Bus");
            Console.WriteLine("Enter 2 to Update Bus");
            Console.WriteLine("Enter 3 to Delete Bus");
            Console.WriteLine("Enter 4 to Find Bus");
            Console.WriteLine("Enter 5 to List Buses");
            Console.WriteLine("Enter 6 to Check Available buses");
            Console.WriteLine("Enter 0 to go back");

            Console.Write("Choose an option: ");

        }

        public static void RegisterBus()
        {
            Console.WriteLine("Enter bus model");
            string model = Console.ReadLine();

            Console.WriteLine("Enter bus capacity");
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter bus PlateNumber");
            string platenumber = Console.ReadLine();

            Console.WriteLine("Enter your bustype");
            Bustype bustype = new Bustype();

        }
    }
}
