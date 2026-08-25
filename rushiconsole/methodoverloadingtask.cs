//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Text;

//namespace rushiconsole
//{
//    internal class methodoverloadingtask
//    {
//        void area(int length , int width) // Area Of Reactangle
//        {
//            Console.WriteLine("Area Of Reactangle ="+length*width);
//        }
//        void area(int side)// Area Of Square
//        {
//            Console.WriteLine("Area Of Square =" +side*side);
//        }
//        void area(double radius) // Area Of Circle
//        {
//            double area = 3.14 * radius * radius;
//            Console.WriteLine("Area Of Circle =" +area );
//        }
//        void area() // Area Of Triangle
//        {
//            Console.WriteLine("Enter the height:");
//            int height=int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the base:");
//            int side=int.Parse(Console.ReadLine());
//            double area = 0.5 * height * side;
//            Console.WriteLine("Area Of Triangle =" + area);
//        }

//        public static void Main(string[] args)
//        {
//            methodoverloadingtask m=new methodoverloadingtask();
//            Console.WriteLine("Enter the width:");
//            int width = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the side:");
//            int side=int.Parse(Console.ReadLine());
//            Console.WriteLine("Call Method and display area of triangle");
//            m.area();
//            Console.WriteLine("Call Method and display area of Reactangle");
//            m.area(width,side);
//            Console.WriteLine("Call Method and display area of square");
//            m.area(side);
//            Console.WriteLine("Call Method and display area of circle");
//            Console.WriteLine("Enter the radius:");
//            double radius = double.Parse(Console.ReadLine());
//            m.area(radius);
//        }
//    }
//}
