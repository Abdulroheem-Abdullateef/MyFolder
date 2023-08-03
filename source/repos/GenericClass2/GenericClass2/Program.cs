using System;

namespace GenericClass2
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonList<Teacher> teachers = new PersonList<Teacher>();
            teachers.Add(new Teacher("123", "Miss", 23,"Bola", "Aderibigbe"));
            teachers.Add(new Teacher("3", "Mr", 22, "Ola", "Agbaje"));

            var p = teachers.FindOldest();
            Console.WriteLine($"{p.FirstName} {p.Surname} is the oldest");
            


        }
    }
}
