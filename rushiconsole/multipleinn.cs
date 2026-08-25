//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    interface amazon
//    {
//        public void addtocart();
//    }
//    interface swiggy
//    {
//        public void orderfood();
//    }
//    interface blinkt 
//    {
//        public void homedelivery();
//    }
//    internal class multipleinn : amazon, blinkt, swiggy
//    {
//        public void addtocart()
//        {
//            Console.WriteLine("Item added to cart");
//        }
//        public void orderfood()
//        {
//            Console.WriteLine("Food ordered");
//        }
//        public void homedelivery()
//        {
//            Console.WriteLine("Home delivery requested");
//        }

//        public static void Main(string[] args)
//        {
//            multipleinn m = new multipleinn();
//            m.addtocart();
//            m.orderfood();
//            m.homedelivery();
//        }
//    }
//}
