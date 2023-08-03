using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Class_Topic
{
    class Student
    {
        public string Name { get; set; } 

        public int Age { get; set; }

        public string Gender { get; set; }
        List <string>  Record { get; set; }


        public override string ToString()
        {
           return ($"Name:{Name} \n Age:{Age} \n Gender: {Gender}");

        }



    }
}
