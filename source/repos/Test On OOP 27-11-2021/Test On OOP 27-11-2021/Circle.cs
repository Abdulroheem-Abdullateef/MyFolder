using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_On_OOP_27_11_2021
{
   public class Circle
   {
       readonly double PIE = 3.142;
      private double  Radius;

        public Circle(double radius)
        {
            Radius = radius;
            PIE = 3.5;
        }

        
        public double GetArea()
        {
            return PIE * Radius * Radius;

        }
        public string First { private get; set; }
        //public void SetArea(double radius)
        //{
        //    Radius = radius;
        //}
   }
     
   

}

