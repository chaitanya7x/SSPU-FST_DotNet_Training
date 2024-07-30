using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class SyncThread
    {
        private static void func2(object obj) 
        {
            Console.WriteLine("Thread 1 is Executed");
        }
        private static void func1(object obj) 
        {
            Console.WriteLine("Thread 2 is Executed"); 
        }

        public static void testJoin()
        {
            Thread t1 = new Thread(func1);
            t1.Start();
            Thread t2 = new Thread(func2);
            t2.Start();
            t1.Join();
            t2.Join();
           


        }
    }
}
