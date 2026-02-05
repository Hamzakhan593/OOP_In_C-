using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_
{
    public class Employee_Service
    {
        public void printEmployee(Employee employee)
        {
            Console.WriteLine("Employee Name: " + employee.Name);
            Console.WriteLine("Age: " + employee.Age);
            Console.WriteLine("Employee ID: " + employee.EmployeeID);
            Console.WriteLine("Position: " + employee.Position);
            Console.WriteLine("Salary: " + employee.Salary);
            Console.WriteLine("Address: " + employee.Address);
            Console.WriteLine("Company: " + employee.Company);
        }
    }
}
