using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_.Abstract_class.Employee_Class
{
    public class FullTimeEmployee : Employee_abs
    {
        public int Hours = 0;
        public FullTimeEmployee(int hours, string name) 
        {
            Hours = hours;
            Name = name;
        }
        public override void CalculateSalary()
        {
            Console.WriteLine($"Full Time Emplyee {Name} Will get full salry");
            Console.WriteLine(30 * Hours * 300);
        }
    }
}
