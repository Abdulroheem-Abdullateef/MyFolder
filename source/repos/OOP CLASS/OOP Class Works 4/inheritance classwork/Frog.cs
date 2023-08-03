using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_classwork
{
    class Frog:Animal
    {
        public Frog(string name, int age)
        {
            Name = name;
            Age = age;

        }
        public override string AnimalSound()
        {
            return "Cru Cru";
        }
    }
}
