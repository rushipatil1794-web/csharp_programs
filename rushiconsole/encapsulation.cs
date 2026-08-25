//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    class bank
//    {
//        private long acno;
//        private string ac_holdername;
//        private int balance;

//        public void setacno(long acno)
//        {
//            this.acno = acno;
//        }
//        public long getacno()
//        {
//            return this.acno;
//        }

//        public void setac_holdername(string ac_holdername)
//        {
//            this.ac_holdername = ac_holdername;
//        }
//        public string getac_holdername()
//        {
//            return ac_holdername;
//        }

//        public void setbalance(int balance)
//        {
//            this.balance = balance;
//        }

//        public int getbalance()
//        {
//            return balance;
//        }

//    }
//    internal class encapsulation
//    {
//        public static void Main(string[] args)
//        {
//            bank b = new bank();
//            b.setacno(1234567890);
//            b.setac_holdername("Rushikesh Patil");
//            b.setbalance(100000);
//            Console.WriteLine("Account Number :" + b.getacno());
//            Console.WriteLine("Account Holdername :" + b.getac_holdername());
//            Console.WriteLine("Account Balance :" + b.getbalance());

//        }
//    }
//}
