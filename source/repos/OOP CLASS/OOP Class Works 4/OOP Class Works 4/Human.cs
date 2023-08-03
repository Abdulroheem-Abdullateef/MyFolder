using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Works_4
{
    public class Human
    {
        
        public string Name;
        public string Last;
        

        public  Human(string name,string last)
        {
            Name = name;
            Last = last;
        }
    
        public string Getname()
        {
            return Name;
        }

        public void SetName (string name)
        {
            Name = name;
        }
        public string GetLast()
        {
            return Last;
        }
            
        public void SetLast (string last)
        {
            Last = last;
        }
    
    
    }
}
