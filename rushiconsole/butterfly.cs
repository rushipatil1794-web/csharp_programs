//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class butterfly
//    {
//        public static void Main(string[] args)
//        {
//            int i, j, n;
//            Console.Write("Enter the number of rows: ");
//            n = Convert.ToInt32(Console.ReadLine());
//            for (i = 1; i <= n; i++)
//            {
//                for (j = 1; j <= i; j++)
//                {
//                    Console.Write("*");
//                }
//                for (j = 1; j <= 2 * (n - i); j++)
//                {
//                    Console.Write(" ");
//                }
//                for (j = 1; j <= i; j++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//            for (i = n; i >= 1; i--)
//            {
//                for (j = 1; j <= i; j++)
//                {
//                    Console.Write("*");
//                }
//                for (j = 1; j <= 2 * (n - i); j++)
//                {
//                    Console.Write(" ");
//                }
//                for (j = 1; j <= i; j++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
