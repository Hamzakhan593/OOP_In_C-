using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_
{
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }
}
