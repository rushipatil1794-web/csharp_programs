//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    class gp
//    {
//        public void gshow()
//        {
//            Console.WriteLine("this is grandparent");
//        }
//    }
//    class p:gp
//    {
//        public void pshow()
//        {
//            Console.WriteLine("this is parent");
//        }
//    }
//    class c : p
//    {
//        public void cshow()
//        {
//            Console.WriteLine("this is child");
//        }
//    }
//    internal class multileval
//    {
//        public static void Main(string[] args)
//        {
//            c op=new c();
//            op.cshow();
//            op.pshow();
//            op.gshow();
//        }
//    }
//}
