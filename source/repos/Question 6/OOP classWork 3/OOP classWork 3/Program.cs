using System;

namespace OOP_classWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Teacher teach = new Teacher("Ade","Jss1","English",true);
            teach.SetName("Ola");
            teach.PrintDetail();


            Teacher teach1 = new Teacher("Olamide", "Jss3", "Math", false);
            teach1.PrintDetail();



        }
    }

    class Teacher
    {
        private string Name;
        private string Class;
        private string Subject;
        private bool IsActive;

        public Teacher(string name,string classes,string subject,bool isactive)
        {
            Name = name;
            Class = classes;
            Subject = subject;
            IsActive = isactive;
        }

        public void SetName(string name)
        {
            Name = name;
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
            Class = classes;
        }

        public string GetClasses()
        {
            return Class;
        }


        public void SetIsactive(bool isactive)
        {
            IsActive = isactive;
        }

        public bool GetIsactive()
        {
            return IsActive;
        }


        public void PrintDetail()
        {
            if (IsActive==true)
            {
                Console.WriteLine($" The name of the teacher is {Name} and he teach class {Class} with {Subject} and isactive");

            }

            else if(IsActive!=true)
            {
                Console.WriteLine($" The name of the teacher is {Name} and he teach class {Class} with {Subject} and not active");
            }
        
        }
    }

}
