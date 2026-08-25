//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    class parent
//    {
//       public int a = 1;
//        public virtual void home()
//        {
            
//            Console.WriteLine("1 bhk");
//        }
//    }
//    class son : parent
//    {
//        public override void home()
//        {
//            int a = 2;
//            Console.WriteLine("Son a = " + a);
//            Console.WriteLine("Parent a = " + base.a);
//            Console.WriteLine("1 bhk renovates .....");
//             base.home();

//        }

//    }
//    internal class methodoverriding
//    {
//        public static void Main(string[] args)
//        {
//            son s = new son();
//            s.home();
//            //s.home();
//        }
//    }
//}
