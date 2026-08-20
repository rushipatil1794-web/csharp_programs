//using System;

//namespace rushiconsole
//{
//    internal class constask
//    {
//        public static void Main(string[] args)
//        {
//            // Parameterized Constructor
//            constask cn = new constask(5, 5);

//            // Default Constructor
//            constask cn1 = new constask();
//        }
//        static  constask()
//        {
//            for (int i = 90; i >= 88; i--)
//            {
//                for (int space = 88; space <= i; space++)
//                {
//                    Console.Write("  ");
//                }

//                for (int j = 90; j >= i; j--)
//                {
//                    Console.Write(Convert.ToChar(i) + " ");
//                }

//                Console.WriteLine();
//            }
//        }
//        //constask() //pattern 2 @@@@
//        //{
//        //    for (int i = 1; i <= 4; i++)
//        //    {
//        //        for (int s = 1; s <= i; s++)
//        //        {
//        //            Console.Write(" ");
//        //        }

//        //        for (int j = 1; j <= 4; j++)
//        //        {
//        //            Console.Write(" @ ");
//        //        }

//        //        Console.WriteLine();
//        //    }
//        //}
//        // Pattern 5: 1 0 1 0
//        private constask()
//        {
//            for (int row = 1; row <= 4; row++)
//            {
//                for (int col = 1; col <= 4; col++)
//                {
//                    if (col % 2 != 0)
//                    {
//                        Console.Write(" 1 ");
//                    }
//                    else
//                    {
//                        Console.Write(" 0 ");
//                    }
//                }

//                Console.WriteLine();
//            }
//        }

//        // Static Constructor
//        //static constask() //pattern 3: 1 2 3 4 5 6
//        //{
//        //    int b = 1;

//        //    for (int i = 1; i <= 3; i++)
//        //    {
//        //        for (int j = 1; j <= i; j++)
//        //        {
//        //            Console.Write(b + " ");
//        //            b++;
//        //        }

//        //        Console.WriteLine();
//        //    }
//        //}


//        // Pattern 2: Star Pattern
//        constask(int num, int s)
//        {
//            for (int i = 1; i <= num; i++)
//            {
//                for (int space = num; space >= i; space--)
//                {
//                    Console.Write(" ");
//                }

//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write(" * ");
//                }

//                Console.WriteLine();
//            }
//        }
//    }
//}