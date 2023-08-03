using System;

namespace OOP_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Dog = new Animal();       
            Console.WriteLine(Dog);

            Phone phone = new Phone();
            phone.SetColour("Black");
            Console.WriteLine(phone.Getcolour());

        }
    }

    class Animal
    {
        public string Name;
        public int NumbersofLegs;
        public string Colour;

        public string Sound()
        {
            string AnimalSound = "";
            return AnimalSound;
        }

    }


    class Phone
    {
        private string Name;
        private string Colour;
        private int Model;


        public string Getcolour()
        {
            return Colour;
        }


        public void SetColour(string Colour)
        {
            this.Colour = Colour;
        } 
    
        public string GetName()
        {
            return Name;
        }  
    
        public void SetName(string Name)
        {
            this.Name = Name;
        }
    
    }



}

