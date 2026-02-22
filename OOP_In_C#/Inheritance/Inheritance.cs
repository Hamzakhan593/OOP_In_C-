using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_.Inheritance
{
    public class Inheritance
    {
        public class Animal
        {
            public void eat()
            {
                Console.WriteLine("Dog is eating");
            }
        }

        public class Dog : Animal 
        {
            public void bark()
            {
                Console.WriteLine("dog is barking");
            }
        }
    }
}
