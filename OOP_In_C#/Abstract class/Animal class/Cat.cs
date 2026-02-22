using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_.Abstract_class.Animal_class
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} Meow Meow");
        }
    }
}
