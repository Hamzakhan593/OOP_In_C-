using OOP_In_C_;



//constructor overloading is a feature in C# that allows you to define multiple constructors with the same name but different parameters.
ConstructorOverloading defaultconstructorOverloading = new ConstructorOverloading();
defaultconstructorOverloading.DisplayInfo();
ConstructorOverloading parameterizedconstructorOverloading = new ConstructorOverloading("Hamza", 24);
parameterizedconstructorOverloading.DisplayInfo();
ConstructorOverloading anotherParameterizedconstructorOverloading = new ConstructorOverloading("Jahangir");
anotherParameterizedconstructorOverloading.DisplayInfo();






//var cardPayments = new List<CardPayment>
//{
//    new CardPayment("1234 5678 9012 3456", "Hamza", "12/25", "123"),
//    new CardPayment("9876 5432 1098 7654", "Jahangir", "11/24", "456"),
//    new CardPayment("5555 6666 7777 8888", "Shahzeb", "10/23", "789")
//};


//CardPaymentLogic cpl = new CardPaymentLogic();
//foreach (var item in cardPayments)
//{
//    cpl.printCardDetails(item);
//}




// function overloading is a feature in C# that allows you to define multiple methods with the same name but different parameters.
//Payment payment = new Payment();
//payment.Pay(1000);
//payment.Pay(1500, "Credit Card");
//payment.Pay(2000, "PayPal", true);



//Student Jahangir = new Student();
//Jahangir.Name = "Jahangir";
//Jahangir.age = -24;
//Jahangir.RollNo = "23bsit04";
//Jahangir.Batch = "2023";
//Jahangir.Course = "BSIT";
//Jahangir.Department = "IT";
//Jahangir.Address = "Karachi";
//Jahangir.Univerity = "SBBU";

//Student Hamza = new Student();
//Hamza.Name = "Hamza";
//Hamza.age = 24;
//Hamza.RollNo = "23bsit02";
//Hamza.Batch = "2023";
//Hamza.Course = "BSIT";
//Hamza.Department = "IT";
//Hamza.Address = "Karachi";
//Hamza.Univerity = "SBBU";

//Student Shahzeb = new Student();
//Shahzeb.Name = "Shahzeb";
//Shahzeb.age = -17;
//Shahzeb.RollNo = "23bsit37";
//Shahzeb.Batch = "2023";
//Shahzeb.Course = "BSIT";
//Shahzeb.Department = "BBA";
//Shahzeb.Address = "Karachi";
//Shahzeb.Univerity = "SBBU";

//// This will show the student information of Jahangir and that the isTrue method
//Jahangir.studentInfoPrint();
//Console.WriteLine(Jahangir.isTrue());
//Console.WriteLine();

//// This will show the student information of Jahangir and that the isTrue method
//Hamza.studentInfoPrint();
//Console.WriteLine(Hamza.isTrue());
//Console.WriteLine();

//// This will show that the isTrue method returns true for Jahangir and Hamza
//// because their age is greater than 18, while it returns false for Shahzeb
//// because his age is less than 18.
//Shahzeb.studentInfoPrint();
//Console.WriteLine(Shahzeb.isTrue());
//Console.WriteLine();

//// This will show that when we assign one object to another, they both point
//// to the same memory location. So, modifying one will affect the other.
//Student s1 = Jahangir;
//s1.Name = "Modified Name";
//Console.WriteLine(Jahangir.Name);



//// Employee Section
//// Creating an Employee object and using Employee_Service to print its details
//Employee Imran = new Employee("Imran", 30, "123tgd", "Developer",
//    200000, "karachi", "TechCorp");
//Employee_Service employee_Service = new Employee_Service();
//employee_Service.printEmployee(Imran);

//Calculator calculator = new Calculator();
//calculator.Add(5, 10);
//calculator.Add(5, 10, 15);
//calculator.Add(5.999, 10, 15);