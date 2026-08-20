//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class singlearray
//    {
//        void oned_array()
//        {
//            int[] nums = {23,43,45,65,56,78};
//            for(int index=0;index<nums.Length;index++)
//            {
//                Console.WriteLine(nums[index]);
//            }
//        }
//        static void twod_array()
//        {
//            string[,] name = { { "poonm", "tara","jiya" }, { "sweety","omii", "monu" }, { "leela","vira", "sham" } };
//            for(int row=0; row < name.GetLength(0);row++)
//            {
//                for(int col=0; col<name.GetLength(1);col++)
//                {
//                    Console.WriteLine(name[row,col]);
//                }
//            }
//        }
//        static void multi_array()
//        {
//            int[,,] nums = { { {11,12,13 },{21,22,23 } },{ {31,32,33 },{41,42,43 } },{ {51,52,53 },{61,62,63 } } };
//             for(int matrix=0;matrix<nums.GetLength(0);matrix++)
//            {
//                for(int row=0;row<nums.GetLength(1);row++)
//                {
//                    for(int col=0; col<nums.GetLength(2);col++)
//                    {
//                        Console.Write(nums[matrix,row,col]+" " );
//                    }
//                    Console.Write("\n");
//                }
//                Console.Write("\n") ;
//            }
//        }
//        public static void Main(string[] args)
//        {
//            singlearray ob= new singlearray();
//            ob.oned_array();
//            twod_array();
//            multi_array();
//        }
//    }
//}
