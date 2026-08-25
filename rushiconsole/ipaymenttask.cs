//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    interface ipayment
//    {
//        public void pay();
//    }
//    class cashpayment : ipayment
//    {
//        public void pay()
//        {
//            Console.WriteLine(" cash is Payment Done");
//        }
//    }
//    class cardpayment : ipayment
//    {
//        public void pay()
//        {
//            Console.WriteLine(" card is Payment Done");
//        }
//    }
//    internal class ipaymenttask 
//    {
//        public static void Main(string[] args)
//        {
//            ipayment p;
//            Console.WriteLine("Enter the Payment Method");
//            string method = Console.ReadLine();
//            if (method == "cash")
//            {
//                p = new cashpayment();
//                p.pay();
//            }
//            else if (method == "card")
//            {
//                p = new cardpayment();
//                p.pay();
//            }
//            else
//            {
//                Console.WriteLine("Invalid Payment Method");
//            }
//        }

//    }
//}
