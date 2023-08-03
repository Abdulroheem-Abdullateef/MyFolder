using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Works_4
{
    public class Student:Human
    {
        private int Mark ;


        public Student(string name,string last,int mark) : base(name,last)
        {
            Name = name;
            Last = last;
            Mark = mark;
        }

    }
}
