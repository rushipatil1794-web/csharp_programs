//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    interface tejas
//    {
//        public void bankbalance(int amount);
//    }
//    internal class abstraction_demo : tejas
//    {
//        public void bankbalance(int amount)
//        {
//            Console.WriteLine("Bank Balance is "+amount);
//        }

//        public static void Main(string[] args)
//        {
//            int amount;
//            Console.WriteLine("Enter the amount");
//            amount = int.Parse(Console.ReadLine());
//            abstraction_demo a = new abstraction_demo();
//            a.bankbalance(amount);
//        }
//    }
//}