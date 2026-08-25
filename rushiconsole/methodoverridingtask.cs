//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    class hollow
//    {
//        public virtual void pattern()
//        {
//            for (int row = 0; row <= 4; row++)
//            {
//                for (int col = 0; col <= 4; col++)
//                {
//                   if(row==0 || row== 4 || col == 0 || col == 4)
//                    {
//                        Console.Write(" * ");
//                    }
//                    else
//                    {
//                        Console.Write("   ");
//                    }
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//    class solid:hollow
//    {
//        public override void pattern()
//        {
//            Console.WriteLine("____________________");
//            Console.WriteLine("Print Solid Pattern");
//            Console.WriteLine("____________________");
//            for (int i = 0; i <=4; i++)
//            {
//                for(int j = 0; j <=4; j++)
//                {
//                    Console.Write(" * ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine("____________________");
//            Console.WriteLine("Print Hollow Pattern");
//            Console.WriteLine("____________________");
//            base.pattern();
//        }
//    }
//    internal class methodoverridingtask
//    {
//        public static void Main(string[] args)
//        {
//            solid s=new solid();
//            s.pattern();
//        }
//    }
//}
