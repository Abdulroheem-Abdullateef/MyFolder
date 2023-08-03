using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Square : Building
    {    
        public string GetName()
        {
            return "square";
        }
        
        public int Length { get; set; }
        
        public Square (int length)
        {
            Length = length;
        }

        public double GetArea()
        {
            double area = Length * Length;
            return area;
        }
    }
}
