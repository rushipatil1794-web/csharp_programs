//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    class ecommerce
//    {
//        public void appname()
//        {
//            Console.WriteLine("amazon,flipcart,messho,ajio");
//        }
//    }
//    class myntra:ecommerce
//    {
//        public void myntrasale()
//        {
//            Console.WriteLine("myntra:50% sale each product");
//        }
//    }
//    class amazon:ecommerce
//    {
//        public void amazonsale()
//        {
//            Console.WriteLine("amazon:70% sale each product");
//        }
//    }
//    class amazonpay:amazon
//    {
//        public void pay()
//        {
//            Console.WriteLine("pay using amazon");
//        }
//    }
//    internal class hybrid
//    {
//        public static void Main(string[] args)
//        {
//            amazonpay a=new amazonpay();
//            a.amazonsale();
//            a.pay();
//            a.appname();
//            Console.WriteLine("-----------------------------");
//            myntra m=new myntra();
//            m.myntrasale();
//        }
//    }
//}
