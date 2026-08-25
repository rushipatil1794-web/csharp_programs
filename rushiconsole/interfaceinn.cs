//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    interface iparent
//    {
//        public void parentmethod();
//    }
//    interface ichild : iparent
//    {
//        public void parentmethod();
//        public void childmethod();
//    }
//    class childclass : ichild
//    {
//        public void parentmethod()
//        {
//            Console.WriteLine("Parent Method");
//        }
//        public void childmethod()
//        {
//            Console.WriteLine("Child Method");
//        }
//    }
//    internal class interfaceinn
//    {
//        public static void Main(string[] args)
//        {
//            childclass c = new childclass();
//            c.parentmethod();
//            c.childmethod();
//        }

//    }
//}
