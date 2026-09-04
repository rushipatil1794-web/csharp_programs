//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    class bank
//    {
//        static double balance = 10000;
//        static object lockobject = new object();
//        public static void person1(double wid_amt)
//        {
//           // Console.WriteLine("_________________________________________");
//            Thread.Sleep(1000);
//            lock (lockobject)
//            { 
//                Console.WriteLine("person1 is trying to withdraw amount: " + wid_amt);
//                Console.WriteLine("checking balance for person1");
//                Console.WriteLine("current balance: " + balance);
//                Thread.Sleep(1000);
//                if (balance > 0)
//                {
//                    if (balance >= wid_amt)
//                    {


//                        balance -= wid_amt;
//                        Console.WriteLine("amount withdrawn successfully by person1");
//                        Console.WriteLine("balance after withdrawal by person1: " + balance);

//                    }
//                    else
//                    {
//                        Console.WriteLine("insufficient balance for withdrawalation");
//                    }
//                }
//                Console.WriteLine("_________________________________________");

//            }
//        }
//        public static void person2(double wid_amt)
//        {
//           // Console.WriteLine("_________________________________________");
//            Thread.Sleep(1000);
//            lock (lockobject)
//            {
//                Console.WriteLine("person2 is trying to withdraw amount: " + wid_amt);
//                Console.WriteLine("checking balance for person2");
//                Console.WriteLine("current balance: " + balance);
//                Thread.Sleep(1000);
//                if (balance > 0)
//                {
//                    if (balance >= wid_amt)
//                    {

//                            balance -= wid_amt;
//                            Console.WriteLine("amount withdrawn successfully by person2");
//                            Console.WriteLine("balance after withdrawal by person2: " + balance);
                        
//                    }
//                    else
//                    {
//                        Console.WriteLine("insufficient balance for withdrawalation");
//                    }
//                }
//                Console.WriteLine("_________________________________________");
//            }
//        }
//    }
//    internal class lockmethod
//    {
//        public static void Main(string[] args)
//        {
//            Thread t1 = new Thread(() => bank.person1(6000));
//            Thread t2 = new Thread(() => bank.person2(5000));
//            t1.Start();
//            t2.Start();
//            t1.Join();
//            t2.Join();
//        }
//    }
//}
