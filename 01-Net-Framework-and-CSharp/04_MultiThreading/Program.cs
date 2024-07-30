using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Single Threading Test
            SingleThreading.TestThread();

            // Multi Thread Test
            MultiThread.TestThread();

            // Thread Details
            Thread t = Thread.CurrentThread;
            t.Name = "First Thread";
            Console.WriteLine("Status of Current Thread = {0}", t.IsAlive);
            Console.WriteLine("Name of Thread = {0}", t.Name);
            Console.WriteLine("Thread Priority = {0}", t.Priority);
            Console.ReadKey();

            // Synchronized Thread Test
            SyncThread.testJoin();

            // Problem Print Method
            Problem.print();
        }
    }
}
