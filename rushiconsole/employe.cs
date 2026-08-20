//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    class emp
//    {
//        int id;
//        string name;
//        string department;
//        string address;
//        double salary;
//        public void get_info()
//        {
//            Console.WriteLine("enter employe id number:");
//            id = int.Parse(Console.ReadLine());
//            Console.WriteLine("enter employe name:");
//            name = Console.ReadLine();
//            Console.WriteLine("enter employe department:");
//            department = Console.ReadLine();
//            Console.WriteLine("enter employe address:");
//            address = Console.ReadLine();
//            Console.WriteLine("enter employe salary:");
//            salary = double.Parse(Console.ReadLine());
//        }
//        public void show()
//        {
//            Console.WriteLine("Employe Id Is :" + id);
//            Console.WriteLine("Employe Name Is :" + name);
//            Console.WriteLine("Employe Department Is :" + department);
//            Console.WriteLine("Employe Address Is :" + address);
//            Console.WriteLine("Employe Salary Is :" + salary);
//        }
//    }
//    internal class employe
//    {
//        public static void Main(string[] args)
//        {
//            emp e = new emp();
//            e.get_info();
//            e.show();
//        }
//    }
//}
