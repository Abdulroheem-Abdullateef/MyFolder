using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_classwork
{
    class Animal
    {
        public string Name;
        public int Age;
        private string gender;



        public virtual string AnimalSound()
        {
            return " Any sound";
        }
        public string Animalstatus()
        {
          return ($"The name of the animal is {Name} of {Age} months with sound {AnimalSound()}");
        }

    }
}
