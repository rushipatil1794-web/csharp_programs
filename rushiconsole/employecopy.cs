//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class employecopy
//    {
//        double salary;
//        string address;
//        string designation;
//        employecopy(double salary,string address,string designation)
//        {
//            this.salary = salary;
//            this.address = address;
//            this.designation = designation;
//        }
//        employecopy(employecopy e)
//        {
//            this.salary = e.salary;
//            this.address = e.address;
//            this.designation = e.designation;
//        }
//        public static void Main(string[] args)
//        {
//            employecopy emp = new employecopy(50000, "123 Main St", "Software Engineer");  
//            Console.WriteLine("Salary: " + emp.salary);
//            Console.WriteLine("Address: " + emp.address);
//            Console.WriteLine("Designation: " + emp.designation);

//            Console.WriteLine(" Copy Construcor");
//            employecopy emp2 = new employecopy(emp);
//            Console.WriteLine("Salary: " + emp2.salary);
//            Console.WriteLine("Address: " + emp2.address);
//            Console.WriteLine("Designation: " + emp2.designation);

//        }
//    }
//}
