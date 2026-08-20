//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class jaggedarray
//    {
//        public static void Main(string[] args)
//        {
//            jag_array();
//            jag_array1 ();
//        }
//        static void jag_array1()
//        {
//            string[][] skills = new string[4][];
//            skills[0]=new string[] {"java","c","sql"};
//            skills[1] = new string[] { "html", "php" };
//            skills[2] = new string[] { "cyber", "cloude" };
//            skills[3] = new string[] { "python","html","java","dotnet" };
//            for (int i = 0; i < skills.Length; i++)
//            {
//                for(int j = 0; j < skills[i].Length; j++)
//                {
//                    Console.Write(skills[i][j]+"  ");
//                }
//                Console.WriteLine("\n");
//            }
//        }
//        static void jag_array()
//        {
//            int[][] numberse = new int[3][];
//            numberse[0] = new int[] { 1, 2, 3 };
//            numberse[1] = new int[] { 2, 3, 4, 5, 6, 7 };
//            numberse[2] = new int[] { 3, 4, 5, 6, 7 };
//            for (int i = 0; i < numberse.Length; i++)
//            {
//                for (int j = 0; j < numberse[i].Length; j++)
//                {
//                    Console.Write(numberse[i][j] + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
