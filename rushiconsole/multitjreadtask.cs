//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    class rightangle
//    {
//        public void rightangletrangle()
//        {
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j <= i; j++)
//                {
//                    if (i == 0 || i == 2)
//                    {
//                        Console.Write(" * ");
//                    }
//                    else
//                    {
//                        Console.Write(" @ ");
//                    }

//                }
//                Console.WriteLine();
//                //Thread.Sleep(1000);
//            }

//        }
//    }
//    class rhombus
//    {
//        public void rhombusshape()
//        {
//            Thread.Sleep(1000);
//            for (int i = 1;i <=4;i++)
//            {
//                for(int space=2;space<=i;space++)
//                {
//                    Console.Write(" ");
//                }
//                for(int j = 1; j <= 4; j++)
//                {
//                    Console.Write(i);
//                }
//                Console.WriteLine();
               
//            }

//        }
//    }
//    class pyramid
//    {
//        public void pyramidshape()
//        {
//            Thread.Sleep(3000);
//            for (int i = 1; i <= 3; i++)
//            {
//                for(int space = 3; space >= i; space--)
//                {
//                    Console.Write(" ");
//                }
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write("* ");
//                }
//                Console.WriteLine();
                
//            }
            
//        }
//    }
//    internal class multitjreadtask
//    {
//        public static void Main(string[] args)
//        {
//            rightangle r1 = new rightangle();
//           // r1.rightangletrangle();
//            rhombus r2 = new rhombus();
//            //r2.rhombusshape();
//            pyramid p1 = new pyramid();
//           // p1.pyramidshape();
//            Thread t1 = new Thread(new ThreadStart(r1.rightangletrangle));
//            t1.Start();
//           // t1.Join();
//            Thread t2 = new Thread(new ThreadStart(r2.rhombusshape));
//            t2.Start();
//           // t2.Join();
//            Thread t3 = new Thread(new ThreadStart(p1.pyramidshape));
//            t3.Start();
//           // t3.Join();

//        }

//    }
//}
