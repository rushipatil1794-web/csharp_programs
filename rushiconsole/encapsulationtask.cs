//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    class atmcard
//    {
//        private long cardno;
//        private string card_holdername;
//        private int password;
//        public void setcardno(long cardno, string card_holdername, int password)
//        {
//            this.cardno = cardno;
//            this.card_holdername = card_holdername;
//            this.password = password;
//        }
//        public long getcardno()
//        {
//            return cardno;
//        }
//        //public void setcard_holdername(string card_holdername)
//        //{
//        //    this.card_holdername = card_holdername;
//        //}
//        public string getcard_holdername()
//        {
//            return card_holdername;
//        }
//        //public void setpassword(int password)
//        //{
//        //    this.password = password;
//        //}
//        public int getpassword()
//        {
//            return password;
//        }
//    }
//    internal class encapsulationtask
//    {
//        public static void Main(string[] args)
//        {
//            atmcard a = new atmcard();
//            a.setcardno(1234567890123456, "Rushikesh Patil", 1234);
//            //a.setcard_holdername("Rushikesh Patil");
//            //a.setpassword(1234);
//            Console.WriteLine("Card Number :" + a.getcardno());
//            Console.WriteLine("Card Holdername :" + a.getcard_holdername());
//            Console.WriteLine("Card Password :" + a.getpassword());
//        }
//    }
//}
