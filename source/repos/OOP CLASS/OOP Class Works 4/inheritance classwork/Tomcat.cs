using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_classwork
{
    class Tomcat:Animal
    {
        public Tomcat(string name, int age)
        {
            Name = name;
            Age = age;

        }
        public override string AnimalSound()
        {
            return "Gbun Gbun";
        }
    }
}
