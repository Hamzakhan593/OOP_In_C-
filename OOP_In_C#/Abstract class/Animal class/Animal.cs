using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_.Abstract_class.Animal_class
{
    public abstract class Animal
    {
        public string Name;
        public Animal(string name)
        {
            Name = name;
        }

        public abstract void MakeSound();

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
}
