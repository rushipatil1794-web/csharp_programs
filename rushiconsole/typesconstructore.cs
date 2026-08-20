//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    internal class typesconstructore
//    {
//        public static void Main(string[] args)
//        {
//            typesconstructore cd1= new typesconstructore(); // object is created then constructor is automatically call
//            typesconstructore cd2= new typesconstructore(3,5); // calling parameterized constructor
//            typesconstructore cd3= new typesconstructore(8); // calling private constructor
//        }
//        typesconstructore(int a, int b) //Parameterized Constructor
//        {
//            Console.WriteLine("---------- Parameterized Constructor ----------");
//            Console.WriteLine("Multiplication is:" + (a * b));
//        }
//        private typesconstructore(int num) //Private Constructor
//        {
//            Console.WriteLine("---------- Private Constructor ----------");
//        }
//        static typesconstructore() // Static Constructor this constructor is calling without creating a object
//        {
//            Console.WriteLine("---------- Static Constructor ----------");
//        }
//        typesconstructore() // default constructor
//        {
//            Console.WriteLine("---------- DEfault Constructor ----------");
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }

//    }
//}
