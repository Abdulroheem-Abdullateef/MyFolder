using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Jamp_App
{
    class Menu
    {
        public static void Menu()
        {
            Register register = new Register("ola", "ade", "olu", "cds", "oau", "male", 2000);
            register.Year(2000);

            List<string> regis = new List<string>();
            Console.Write(" Enter 1 for Register");
            Console.Write(" Enter 2 for Admission Status");
            Console.Write(" Enter 3 for Update Status");
            Console.Write(" Enter 4 to check Admission");
            Console.Write(" Enter 5 for Exit");
            Console.Write(" Choose your Option ");


            Console.Write(" Enter your Firstname");
            var firstname = Console.ReadLine();


            Console.Write(" Enter your Lastname");
            var lastname = Console.ReadLine();


            Console.Write(" Enter your Middlename");
            var Middlename = Console.ReadLine();


            Console.Write(" Enter your Gender");
            var gender = Console.ReadLine();


            Console.Write(" Enter your year of birth");
            var yearofbirth = int.Parse (Console.ReadLine());


            if () Console.Write($" Sorry {firstname} {lastname} you are ");



        }

    }
}
