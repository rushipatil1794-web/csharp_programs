//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    class flowers
//    {
//        public void operationinhashset()
//        {
//            HashSet<string> flowers = new HashSet<string>();

//            Console.WriteLine("Adding flowers to the HashSet:");
//            for (int i = 1; i <= 5; i++)
//            {
//                flowers.Add(Console.ReadLine());
//            }
//            Console.WriteLine("Displaying flowers in the HashSet:");
//            foreach (string flower in flowers)
//            {
//                Console.WriteLine(flower);
//            }
//            Console.WriteLine("Checking if 'Rose' is in the HashSet and removing it if present:");
//            if (flowers.Contains("Rose"))
//            {

//                Console.WriteLine("Rose is in the HashSet.");
//                flowers.Remove("Rose");
//                if (flowers.Contains("rose"))
//                {
//                    Console.WriteLine("rose is in the HashSet.");
//                    flowers.Remove("rose");

//                }
//                else
//                {
//                    Console.WriteLine("rose is not int the HashSet");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Rose is not in the HashSet.");
//            }
//            Console.WriteLine("Displaying flowers in the HashSet:");
//            foreach (string flower in flowers)
//            {
//                Console.WriteLine(flower);
//            }
//        }
//    }
//    internal class hashset
//    {
//        public static void Main(string[] args)
//        {
//            flowers f1= new flowers();
//            f1.operationinhashset();

//        }
//    }
//}
