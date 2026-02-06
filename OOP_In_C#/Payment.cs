using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_
{
    public class Payment
    {
        public int Pay(int amount)
        {
            Console.WriteLine($"Paid {amount} using default method (Cash)");
            return 0;
        }
        public int Pay(int amount, string meth)
        {
            Console.WriteLine($"Paid {amount} using {meth} method");
            return 0;
        }

        public int Pay(int amount, string method, bool isInternational)
        {
            if(isInternational)
            Console.WriteLine($"Paid {amount} using {method} method. International Payment: {isInternational}");
            else
                Console.WriteLine($"Paid {amount} using {method} method");
            return 0;
        }
    }
}
