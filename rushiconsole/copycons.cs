//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class copycons
//    {
//        int id;
//        string email;
//        copycons(int id,string email)
//        {
//            this.id= id;
//            this.email= email;
//        }
//        copycons(copycons c)
//        {
//            this.id = c.id;
//            this.email = c.email;
//        }
//        public static void Main(string[] args)
//        {
//            copycons c1 = new copycons(101, "rahul@example.com");
//            Console.WriteLine("id: " + c1.id);
//            Console.WriteLine("email: " + c1.email);
//            Console.WriteLine("Creating a copy of c1 using copy constructor...");
//            copycons c2 = new copycons(c1);
//            Console.WriteLine("id: " + c2.id);
//            Console.WriteLine("email: " + c2.email);

//        }
//    }
//}
