//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class equvalityofarray
//    {
//        public static void Main(string[] args)
//        {
//            equvalityofarray ob = new equvalityofarray();
//            //ob.equality_array();
//            second_large();
//        }
//        static void second_large()
//        {
//            Console.WriteLine("enter size of array");
//            int size = int.Parse(Console.ReadLine());
//            int[] num = new int[size];
//            int first_large = num[0];
//            int second_large = num[1];
//            Console.WriteLine("enter elements in array:");
//            for (int index = 0; index < num.Length; index++)
//            {
//                num[index] = int.Parse(Console.ReadLine());
//            }

//            for (int index = 1; index < num.Length; index++)
//            {
//                if (num[index] > first_large)
//                {
//                    second_large = first_large;
//                    first_large = num[index];
//                }
//                else if (num[index] < second_large && num[index] != first_large)
//                {
//                    second_large = num[index];
//                }
//            }
           
//            Console.WriteLine(" second Large Array Value Is :" + second_large);
//        }
//        void equality_array()
//        {
//            Console.WriteLine("Enter Size Of first Array:");
//            int first_size = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Size Of Second Array:");
//            int second_size = int.Parse(Console.ReadLine());
//            int[] first = new int[first_size];
//            int[] second = new int[second_size];

//            if (first.Length == second.Length)
//            {
//                Console.WriteLine("Both array size are equal in size");
//                Console.WriteLine("Enetr elements of first array");
//                for (int fi = 0; fi < first.Length; fi++)
//                {
//                    first[fi] = int.Parse(Console.ReadLine());
//                }
//                Console.WriteLine("Enetr elements of first array");

//                for (int si = 0; si < second.Length; si++)
//                {
//                    second[si] = int.Parse(Console.ReadLine());
//                }
//                Boolean notequal = false;

//                for (int i = 0; i < first.Length; i++)
//                {
//                    if (first[i] != second[i])
//                    {

//                        notequal = true;
//                        Console.WriteLine("both array are not equal");
//                        break;

//                    }

//                }
//                if (notequal == false)
//                {
//                    Console.WriteLine("Both array are equal");
//                }

//            }
//            else
//            {
//                Console.WriteLine("Both array size are not equal in size");
//            }



//        }
//    }
//}
