using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Circle:Building
    {   
            public string GetName()
            {
                return "circle";
            }
        

           public int Radius { get; set; }

            public Circle(int raduis)
            {
                Radius = raduis;
            }


            public double GetArea()
            {
                var area = 3.142 * (Radius * Radius);
                return area;
            }
        

    }
}
