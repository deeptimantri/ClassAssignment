using ClassAssignment;

//Employee

/*Employee EmpObj = new Employee(1, "Deepti", 50000);
EmpObj.CalcuateSalary();
Console.WriteLine( EmpObj);
Employee.DisplayCount();

//Product
Product product = new Product() { Id=1,Name="Laptop",Price=30000};
Console.WriteLine(product);
Console.WriteLine("===========Enter the percentage of discount====================");
double DPer = Convert.ToDouble(Console.ReadLine());
double TotalPrice = product.CalculateDiscount(DPer);
Console.WriteLine("===========Product details after discount========================");
Console.WriteLine(product);
Console.WriteLine("Price after discount = "+ TotalPrice);

//Student
Students students = new Students() { RollNo=1,Name="Advait",Percentage=90};
Console.WriteLine("==========Students Details ==========================");
Console.WriteLine(students);*/

Console.WriteLine("Enter Roll no ");
int rNo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Name");
string nm = Console.ReadLine();

Console.WriteLine("Enter Percentage");
int per = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Course Id");
int cId = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Course Name");
string cName = Console.ReadLine();

Console.WriteLine("Enter Fees ");
int fees = Convert.ToInt32(Console.ReadLine());
Course c= new Course() { CourseId=cId,Name=cName,Fees = fees };

Students s = new Students() { RollNo = rNo, Name = nm, Percentage = per, MyCourse = c };
Console.WriteLine( s.Name);
Console.WriteLine( s.);


