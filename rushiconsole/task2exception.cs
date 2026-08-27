//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class task2exception
//    {
//        public static void Main(string[] args)
//        {
//            double[] nums = new double[2];
//            nums[0] = 56.1;
//            nums[1] = 33.7;
//            int a = 10, b = 0, c = 0;

//            try
//            {
                
//                nums[2] = 48.7;


//            }

//            catch (Exception ex)
//            {
//                try
//                {
//                    c = a / b;
//                }
//                catch (DivideByZeroException e)
//                {
//                    Console.WriteLine("Error: " + e.Message);
//                }
//                Console.WriteLine("Error: " + ex.Message);

//            }


//            finally
//            {
//                for (int i = 0; i < nums.Length; i++)
//                {
//                    Console.WriteLine(nums[i]);
//                }
//                Console.WriteLine(c);
//            }
//            Console.WriteLine("Finally BlockExecution completed.....");
//        }
//    }
//}

