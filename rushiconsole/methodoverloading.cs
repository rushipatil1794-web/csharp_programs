//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class methodoverloading
//    {
//        void payment()// 1. by no parameter
//        {
//            Console.WriteLine("using phone pay");
//        }
//        void payment(int a)// 2. by parameter
//        {
//            Console.WriteLine("using google pay");
//        }
//        void payment(string b)// 3. by changing data type
//        {
//            Console.WriteLine("using paytm");
//        }
//        void payment(int a,string n)// 4. by passing number of parameters
//        {
//            Console.WriteLine("using amazon pay");
//        }
//        void payment(string a, int b)// 1. by changing sequence of parameter
//        {
//            Console.WriteLine("using debit card");
//        }
//        public static void Main(string[] args)
//        {
//            methodoverloading ob= new methodoverloading();
//            ob.payment();
//            ob.payment(5);
//            ob.payment("rushi");
//            ob.payment(12, "rushi");
//            ob.payment("rushi", 10);

//        }
//    }
//}
