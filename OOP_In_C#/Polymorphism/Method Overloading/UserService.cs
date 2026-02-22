using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_.Polymorphism
{
    public class UserService
    {
        public string GetUser(int id)
        {
            return $"User fetched by ID: {id}";
        }

        public string GetUser(string email)
        {
            return $"User fetched by Email: {email}";
        }
    }

}
