using System;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> numbers = new GenericList<int>();
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(2);


            Console.WriteLine(numbers.Count());

            GenericList<Person> persons = new GenericList<Person>();
            Person person = new Person(19,"Adeolu");
            Person person1 = new Person(22, "Adeo");
            string a = person.Set("Ola");
            Console.WriteLine(a);
            persons.Add(person);
            persons.Add(person1);
            Console.WriteLine(persons.Count());


        }



    }
}
