using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_.Polymorphism.Method_Overriding
{
    public class Animal_Overriding
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }
}
