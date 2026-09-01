using System;
using System.Collections.Generic;
using System.Text;

namespace rushiconsole
{
    internal class threadtask
    {
        public  void task1()
        {
            Console.WriteLine("task1 is running");
        }
        public static void Main(string[] args)
        {
            threadtask tt = new threadtask();
            Console.WriteLine("curent thread is " + Thread.CurrentThread);
            Thread t1 = new Thread(tt.task1);
            t1.Name = "thread1";
            t1.Priority = ThreadPriority.BelowNormal;
            Console.WriteLine("thread name is " + t1.Name);
            Console.WriteLine("thread priority is " + t1.Priority);
            Console.WriteLine("thread state is " + t1.ThreadState);
        }
    }
}
