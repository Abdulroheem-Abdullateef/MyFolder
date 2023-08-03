using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Works_4
{
    public class ClassWorkers : Human
    {
        private double Wages;
        private int HourWorked;
        

        public ClassWorkers(string name,string last,double wages,int hourworked): base (name, last)
        {
            Name = name;
            Last = last;
            Wages = wages;
            HourWorked = hourworked;

        }
    
        public void  CalculateHourlyWages()
        {

           Wages = Wages / HourWorked;
            return;
        }
    
    
    }
}
