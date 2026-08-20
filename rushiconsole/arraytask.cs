//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class arraytask
//    {
//       static void task3()
//        {
//            double [] num = {65.2,39.7,86.4};
//            double large = num[0];
//            for (int index = 1; index < num.Length; index++)
//            {
//                if (num[index]>large)
//                {
//                    large= num[index];
//                }
                
//            }
//            Console.WriteLine("Large Array Value Is :" + large);
//        }
//        static void task2()
//        {
//            int [] num;
//            int sum=0;
//            Console.WriteLine("Enter Size Of Array:");
//            int size = int.Parse(Console.ReadLine());
//            num = new int[size];
//            for (int index = 0; index < num.Length; index++)
//            {
//                Console.WriteLine("Enetr valus in array");
//                num[index]=int.Parse(Console.ReadLine());
//            }
//            for (int index = 0; index < num.Length; index++)
//            {
//                 sum= sum+ num[index];
//            }
//            Console.WriteLine("sum of array is :"+sum);
//        }
//        static void task1()
//        {
//            int [] num;
//            Console.WriteLine("Enter Size Of Array:");
//            int size=int.Parse(Console.ReadLine());
//            num = new int[size];
//            for (int index = 0; index < num.Length; index++)
//            {
//                Console.WriteLine("Enetr valus in array index = " + num[index]);
//                num[index] = int.Parse(Console.ReadLine());
//            }
            
//        }
//        public  static void Main(string[] args)
//        {
//            Console.WriteLine("\t\tTask 3\t\t");
//            task3();
//            Console.WriteLine("\t\tTask 2\t\t");
//            task2();
//            Console.WriteLine("\t\tTask 1\t\t");
//            task1();
//        }
//    }
//}
