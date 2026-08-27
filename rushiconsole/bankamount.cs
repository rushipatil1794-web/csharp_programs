//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class bankamount
//    {
//        class InsufficientBalanceException : Exception
//        {
//            public InsufficientBalanceException(string message) : base(message)
//            {
//            }
//        }
//        public static void Main(string[] args)
//        {
//            int bank_blance = 10000;
//            Console.WriteLine("Welcome to the ATM");
//            Console.WriteLine("Your bank balance is: " + bank_blance);
//            Console.WriteLine("__________________________________");
//            Console.WriteLine("Enter the amount to withdraw: ");
//            int withdraw_amount = int.Parse(Console.ReadLine());
//            if (withdraw_amount <= bank_blance)
//            {
//                Console.WriteLine(withdraw_amount + "Amount withdraw successfully: ");
//            }
//            else
//            {
//                throw new InsufficientBalanceException("oops!! you can't withdraw money as you have insufficient balance!!!!");
//            }
//        }
//    }
//}
