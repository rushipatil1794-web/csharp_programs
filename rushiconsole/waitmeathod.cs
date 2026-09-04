//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace rushiconsole
//{
//    class WaitExample
//    {
//        static object obj = new object();

//        // Thread 1
//        static void WaitTask()
//        {
//            lock (obj)
//            {
//                Console.WriteLine("Thread 1: Waiting...");

//                // Thread 1 इथे थांबेल
//                Monitor.Wait(obj);

//                Console.WriteLine("Thread 1: Resumed!");
//            }
//        }

//        // Thread 2
//        static void PulseTask()
//        {
//            Thread.Sleep(2000);

//            lock (obj)
//            {
//                Console.WriteLine("Thread 2: Sending Pulse...");

//                // Thread 1 ला उठवतो
//                Monitor.Pulse(obj);
//            }
//        }

//        static void Main()
//        {
//            Thread t1 = new Thread(WaitTask);
//            Thread t2 = new Thread(PulseTask);

//            t1.Start();
//            t2.Start();

//            t1.Join();
//            t2.Join();

//            Console.WriteLine("Main Thread: Program Finished");
//        }
//    }
//}
