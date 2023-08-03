using System;

namespace inheritance_classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dog = new Dog("Poppy", 21);
            var Cat = new Cat("Ologbo", 13);
            var Kitten = new Kitten("Omo Ologbo", 34);
            var Tomcat = new Frog("Opolo", 11);
            var Frog = new Dog("Frog ", 21);
           

            Animal[] animals = { Dog, Cat, Kitten, Tomcat, Frog };

            foreach (var item in animals)
            {
                Console.WriteLine(item.Animalstatus());
            }


        }
    }
}
