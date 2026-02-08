using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_
{
    public class ConstructorOverloading
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public ConstructorOverloading()
        {
            Name = "Unknown";
            Age = 0;
        }
        public ConstructorOverloading(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public ConstructorOverloading(string name)
        {
            Name = name;
            Age = 0; 
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
