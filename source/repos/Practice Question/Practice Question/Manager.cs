using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Question
{
    class Manager
    {
       public static  int ID { get; set; }
        List<Student> Record = new List<Student>();

        public Manager(int id)
        {
            ID = id;
        }

    }
}
