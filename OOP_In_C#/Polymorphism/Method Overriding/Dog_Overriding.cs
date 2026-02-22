using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_.Polymorphism.Method_Overriding
{
    public class Dog_Overriding : Animal_Overriding
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
}
