using System;

namespace OOP_ClassWorks_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Teacher teachers = new Teacher();
            teachers.SetName("Aderibigbe");
            teachers.SetClasses("Jss1");
            teachers.SetSubject("English");
            teachers.SetIsactive(true);
            teachers.PrintTeachersDetails();
        }
      
    }

    class Teacher
    {
        private string Name;
        private string Subject;
        private string Classes;
        private bool Isactive;
        
        public void SetName(string name)
        {
            Name=name;
        }

        public string GetName()
        {
            return Name;
        }


        public void SetSubject(string subject)
        {
            Subject = subject;
        }

        public string GetSubject()
        {
            return Subject;
        }


        public void SetClasses(string classes)
        {
            Classes = classes;
        }

        public string GetClasses()
        {
            return Classes;
        }


        public void SetIsactive(bool isactive)
        {
            Isactive = isactive;
        }

        public bool GetIsactive()
        {
            return Isactive;
        }


        public void PrintTeachersDetails()
        {
            if (Isactive==true)
            {

                Console.WriteLine($" {Name} isactive and he teach {Subject} with class {Classes} ");
            }
            else
            {
                Console.WriteLine($" {Name} isactive and he teach {Subject} with class {Classes} ");
            }
            
        }



    }

}
