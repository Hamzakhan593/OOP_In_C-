using OOP_In_C_;

Student Jahangir = new Student();
Jahangir.Name = "Jahangir";
Jahangir.Age = -24;
Jahangir.RollNo = "23bsit04";
Jahangir.Batch = "2023";
Jahangir.Course = "BSIT";
Jahangir.Department = "IT";
Jahangir.Address = "Karachi";
Jahangir.Univerity = "SBBU";

Student Hamza = new Student();
Hamza.Name = "Hamza";
Hamza.Age = 24;
Hamza.RollNo = "23bsit02";
Hamza.Batch = "2023";
Hamza.Course = "BSIT";
Hamza.Department = "IT";
Hamza.Address = "Karachi";
Hamza.Univerity = "SBBU";

Student Shahzeb = new Student();
Shahzeb.Name = "Shahzeb";
Shahzeb.Age = 17;
Shahzeb.RollNo = "23bsit37";
Shahzeb.Batch = "2023";
Shahzeb.Course = "BSIT";
Shahzeb.Department = "BBA";
Shahzeb.Address = "Karachi";
Shahzeb.Univerity = "SBBU";

// This will show the student information of Jahangir and that the isTrue method
Jahangir.studentInfoPrint();
Console.WriteLine(Jahangir.isTrue());
Console.WriteLine();

// This will show the student information of Jahangir and that the isTrue method
Hamza.studentInfoPrint();
Console.WriteLine(Hamza.isTrue());
Console.WriteLine();

// This will show that the isTrue method returns true for Jahangir and Hamza
// because their age is greater than 18, while it returns false for Shahzeb
// because his age is less than 18.
Shahzeb.studentInfoPrint();
Console.WriteLine(Shahzeb.isTrue());
Console.WriteLine();

// This will show that when we assign one object to another, they both point
// to the same memory location. So, modifying one will affect the other.
Student s1 = Jahangir;
s1.Name = "Modified Name";
Console.WriteLine(Jahangir.Name);

Employee Imran = new Employee("Imran", 30, "123tgd", "Developer", 200000, "Sanghar", "TechCorp");
Employee_Service employee_Service = new Employee_Service();
employee_Service.printEmployee(Imran);
