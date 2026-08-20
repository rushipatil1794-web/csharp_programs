//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    class country // parent class
//    {
//        public void show_country()
//        {
//            Console.WriteLine("India");
//            Console.WriteLine("America");
//            Console.WriteLine("Russia");
//        }
//    }
//    class state:country // child class of country
//    {
//        public void show_state()
//        {
//            Console.WriteLine("Maharashtra");
//            Console.WriteLine("Karnataka");
//            Console.WriteLine("Bihar");
//        }
//    }
//    class city:state // child class of state
//    {
//        public void show_punespecial()
//        {
//            Console.WriteLine("Iskon Temple");
//            Console.WriteLine("Shremant Dagadushet");
//            Console.WriteLine("Sarasbag");
//        }
//    }
//    internal class multilevaltask
//    {
//        public static void Main(string[] args)
//        {
//            city c=new city();
//            Console.WriteLine("Countris:");
//            c.show_country();
//            Console.WriteLine("States In Inadia:");
//            c.show_state();
//            Console.WriteLine("Pune City Special");
//            c.show_punespecial();
//        }
//    }
//}
