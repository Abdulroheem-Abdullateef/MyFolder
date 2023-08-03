using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Indexers_Iteration_and_Enumerators
{
    class Record
    {
        private string Fullname { get; set; }

        List<string> StudentRecordName { get; set; }

        public string  this [int i]
        {
            get
            {
                if (i > StudentRecordName.Count)
                {
                    Console.WriteLine(" your are out of bound");
                }

                else
                {
                    return StudentRecordName[i];
                }
            }

            set
            {
                if (!char.IsLetter(Fullname))
                {

                }
            }
        }

        public Record( string fullname)
        {
            Fullname = fullname;
            StudentRecordName = new List<string>();
        }
    }













    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    

}
