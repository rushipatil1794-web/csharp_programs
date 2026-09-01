//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
    
//    internal class multithreads
//    {
//        public static void crushtask()
//        {
//            Console.WriteLine("here candy crush is running");
//            Console.WriteLine("thread 1 is executing task....." + Thread.CurrentThread);
//        }
//        public static void crussound()
//        {
//            Console.WriteLine("here candy crush sound is running");
            
//        }
//        public static void multithreadtask()
//        {
//            crushtask();
//            crussound();
            
//        }
//        public static void Main(string[] args)
//        {
//            //Console.WriteLine("Main thread is executing task....." + Thread.CurrentThread);
//            //Console.WriteLine("using single thread to single task");
//            //Thread t1 = new Thread(crushtask);
//            //t1.Start();
//            //Console.WriteLine("using single thread to multiple task");
//            //Thread t2 = new Thread(multithreadtask);
//            //t2.Start();
//            Console.WriteLine("using multiple threads to single task");
//            Thread t3 = new Thread(crushtask);
//            Thread t4 = new Thread(crushtask);
//            t3.Start();
//            t4.Start();
//            ////Console.WriteLine("using multiple threads to multiple task");
//            ////Thread t5 = new Thread(crushtask);
//            ////Thread t6 = new Thread(crussound);
//            ////t5.Start();
//            ////t6.Start();


//        }
//    }
//}
