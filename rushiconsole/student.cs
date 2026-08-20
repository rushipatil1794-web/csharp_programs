//using System;
//using System.Collections.Generic;
//using System.Security.Cryptography;
//using System.Text;

//namespace rushiconsole
//{
//    class stud
//    {
//        int roll;
//        string name;
//        string add;
//        public void get_info()
//        {
//            Console.WriteLine("enter student roll number:");
//            roll = int.Parse(Console.ReadLine());
//            Console.WriteLine("enter student name:");
//            name = Console.ReadLine();
//            Console.WriteLine("enter student address:");
//            Console.ReadLine();
//        }
//        public void show()
//        {
//            Console.WriteLine("Student Roll Is :" + roll);
//            Console.WriteLine("Student Name Is :" + name);
//            Console.WriteLine("Student Address Is :" + add);
//        }
//    }
//    internal class student
//    {
//        int roll;
//        string name;
//        string email;
//        void read()
//        {
//            Console.WriteLine("reading book");
//        }
//        void walk()
//        {
//            Console.WriteLine("is walking");
//        }
//        public static void Main(string[] args)
//        {
//            stud student = new stud();
//            student.get_info();
//            student.show();
//            student s = new student();
//            s.roll = 34;
//            s.name = "Rushi";
//            s.email = "rushipatil1794@gmail.com";
//            s.read();
//            s.walk();
//            student s1 = new student();
//            s1.roll = 54;
//            s1.name = "Rohit";
//            s1.email = "rohitpatil1794@gmail.com";
//            s1.read();
//            s1.walk();

//        }
//    }
//}
