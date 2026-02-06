using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeeID { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }

        public Employee(string name, int age, string employeeID,
            string position, double salary, string address, string company)
        {
            Name = name;
            Age = age;
            EmployeeID = employeeID;
            Position = position;
            Salary = salary;
            Address = address;
            Company = company;
        }
    }
}
