//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    class institude // parent class
//    {
//        public void pune_institude()
//        {
//            Console.WriteLine("1.Fortune Cloude");
//            Console.WriteLine("2.Qspyder");
//            Console.WriteLine("3.Up Skills");

//        }

//    }
//    class fortunecloude:institude first child class of institude
//    {
//        public void fortune_course()
//        {
//            Console.WriteLine("1:java fullstack");
//            Console.WriteLine("2..net fullstack");
//            Console.WriteLine("3.Up python fullstack");
//            Console.WriteLine("4.cyber secqurity");
//            Console.WriteLine("5.aws cloude");
//            Console.WriteLine("6.Up da/ds");
//        }
//    }
//    class qspyder : institude //second child class of institude
//    {
//        public void qspde_course()
//        {
//            Console.WriteLine("1:java fullstack");
//            Console.WriteLine("2.Up python fullstack");
//            Console.WriteLine("3.cyber secqurity");
//            Console.WriteLine("4.Up da/ds");
//        }
//    }
//    internal class hirearchicaltask
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Create fortune cloude object");
//            fortunecloude f=new fortunecloude();
//            Console.WriteLine("Insitude Names:");
//            f.pune_institude();
//            Console.WriteLine("Prrovide coureses:");
//            f.fortune_course();
//            Console.WriteLine("____________________________");
//            Console.WriteLine("Create fortune cloude object");
//            qspyder qspyder = new qspyder();
//            Console.WriteLine("Insitude Names:");
//            qspyder.pune_institude();
//            Console.WriteLine("Prrovide coureses:");
//            qspyder.qspde_course();
//        }
//    }
//}
