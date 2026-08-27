//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class voting
//    {
       
//        class NotEligibleToVoteException : Exception
//        {
//            public NotEligibleToVoteException(string message) : base(message)
//            {
//            }
//        }
//        public static void Main(string[] args)
//        {
//            int age;
//            Console.WriteLine("Enter your age: ");
//            age = int.Parse(Console.ReadLine());
//            if (age >= 18)
//            {
//                Console.WriteLine("You are eligible to vote.");
//            }
//            else
//            {
//                throw new NotEligibleToVoteException("You are not eligible to vote as you are under 18 years of age.");
//            }
//        }
//    }
//}

