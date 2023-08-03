using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_classwork
{
    class Kitten:Animal
    {
        public Kitten(string name, int age)
        {
            Name = name;
            Age = age;

        }
        public override string AnimalSound()
        {
            return "Miun Miun";
        }

    }
}
