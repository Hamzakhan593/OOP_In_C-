using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace OOP_In_C_
{
    public class Student
    {
        //public string name;
        //public int age;
        //public string RollNo;
        //public string Batch;
        //public string Course;
        //public string department;
        //public string Address;
        //public string Univerity;
        public string Name { get; set; }
        private int Age { get; set; }
        public string RollNo { get; set; }
        public string Batch { get; set; }
        public string Course { get; set; }  
        public string Department { get; set; }
        public string Address { get; set; }
        public string Univerity { get; set; }

        public int age
        {
            get { return Age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age cannot be negative. Setting age to 0.");
                    Age = 0;
                }
                else
                {
                    Age = value;
                }
            }
        }

        public void studentInfoPrint()
        {
            Console.WriteLine($"Student Information of:{Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"RollNo: {RollNo}");
            Console.WriteLine($"Batch: {Batch}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"department: {Department}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Univerity: {Univerity}");
        }

        public bool isTrue()
        {
            return true? Age > 18 : false;
        }

    }
}
