//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading;
//namespace rushiconsole
//{
//    class signal
//    {
//        static object ob = new object();
//        static int turn = 1;

//       public static void redlight()
//        {
//            lock (ob)
//            {
//                while (turn != 1)
//                {
//                    Monitor.Wait(ob);
//                }

//                Console.WriteLine("RED LIGHT - STOP");
//                Console.WriteLine("RED Thread - Signal Changed");

//                turn = 2;

//                Monitor.PulseAll(ob);
//            }
//        }

//       public static void yellowlight()
//        {
//            lock (ob)
//            {
//                while (turn != 2)
//                {
//                    Monitor.Wait(ob);
//                }

//                Console.WriteLine("YELLOW LIGHT - GET READY");

//                turn = 3;

//                Monitor.PulseAll(ob);
//            }
//        }

//       public static void greenlight()
//        {
//            lock (ob)
//            {
//                while (turn != 3)
//                {
//                    Monitor.Wait(ob);
//                }

//                Console.WriteLine("GREEN LIGHT - GO");

//                turn = 4;

//                Monitor.PulseAll(ob);
//            }
//        }
//    }
//    internal class signaldemo
//    {
//        public static void Main(string[] args)
//        {

//            Thread t1 = new Thread(signal.redlight);
//            Thread t2 = new Thread(signal.yellowlight);
//            Thread t3 = new Thread(signal.greenlight);
//            t1.Start();
//            t2.Start();
//            t3.Start();
//            t1.Join();
//            t2.Join();
//            t3.Join();
//            Console.WriteLine("Main Thread: Program Finished");
//        }
//    }
//}
