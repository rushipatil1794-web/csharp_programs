//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class hirearchical
//    {
//        class payment
//        {
//            public void multipleways()
//            {
//                Console.WriteLine("payment method:credit,debit,cod,upi");
//            }
//        }
//        class debit:payment
//        {
//            public void ways1()
//            {
//                Console.WriteLine("payment done using debit card");
//            }
//        }
//        class credit : payment
//        {
//            public void ways2()
//            {
//                Console.WriteLine("payment done using credit card");
//            }
//        }
//        public static void Main(string[] args)
//        {
//            credit c=new credit();
//            c.multipleways();
//            c.ways2();

//            debit d=new debit();
//            d.multipleways();
//            d.ways1();
//        }
//    }
//}
