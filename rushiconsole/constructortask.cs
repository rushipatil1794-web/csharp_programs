//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class constructortask
//    {
//        static constructortask() //pattern 1 use static constructor
//        {
//            Console.WriteLine("pattern 1 use static constructor");
//            for (int row = 0; row <4;row++)
//            {
//                for(int col = 65; col <69;col++)
//                {
//                    Console.Write(" " + Convert.ToChar(col) + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//        private constructortask(int num) // pattern 2 use private constructor
//        {
//            Console.WriteLine("pattern 2 use private constructor");
//            for (int row = 0; row <= 2; row++)
//            {
//                for (int col = 0; col <= 2; col++)
//                {
//                    if (row == 0 || col == 0 && row == 0 || col == 1 && row == 0 || col == 2 && row == 1 || col == 0 && row == 1 || col == 2 && row == 2 || col == 0 && row == 2 || col == 1 && row == 2 || col == 2)
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
//        constructortask(int x, int y) // pattern 3 use parametraized constructor
//        {
//            Console.WriteLine("pattern 3 use parametraized constructor");
//            for (int row = 1; row <= 4; row++)
//            {
//                for (int col = 0; col <= 3; col++)
//                {
//                    if (row == 1 || row == 3)
//                    {
//                        Console.Write(" @ ");
//                    }
//                    else
//                    {
//                        Console.Write(" # ");
//                    }
//                }
//                Console.WriteLine();
//            }
//        }
//        constructortask() // pattern 4 use default constructor
//        {
//            Console.WriteLine("pattern 4 use default constructor");
//            for (int row = 1; row < 4; row++)
//            {
//                for (int col = 1; col <4; col++)
//                {
//                    Console.Write(" " +row+ " ");
//                }
//                Console.WriteLine();
//            }
//        }
        
//        public static void Main(string[] args)
//        {
            
//            constructortask cn2= new constructortask(8);// private constructor call 
//            constructortask cn3= new constructortask(10,4);// paramerized constructor call
//            constructortask cn4 = new constructortask();// default constructor call
//        }
//    }
//}
