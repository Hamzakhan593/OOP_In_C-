using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_.Abstract_class.Employee_Class
{
    public class PartTimeEmployee : Employee_abs
    {
        public int Hours;
        public PartTimeEmployee(int hours, string name) 
        {
            Hours = hours;
            Name = name;
        }
        public override void CalculateSalary()
        {
            Console.WriteLine($"Part Time Empolyee {Name} Will get Half salary");
            Console.WriteLine(30 * Hours * 150);
        }
    }
}
