using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class SingleThreading
    {
        static void DisplayNum()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method1 :" +i);
            }
        }

        public static void TestThread()
        {
            Thread t1 = new Thread(DisplayNum);
            t1.Start();
            Console.Read();
        }
    }

    class MultiThread
    {
        public static void print1()
        {
            for (int i = 0; i <= 4; i++) 
            {
                Console.WriteLine("i value : {0}",i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("First Method Complete");
        }

        public static void print2()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("i value : {0}", i);
                //Thread.Sleep(1000);
            }
            Console.WriteLine("Second Method Complete");
        }

        public static void print3()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("i value : {0}", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Third Method Complete");
        }
        public static void print4()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("i value : {0}", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Fourth Method Complete");
        }

        public static void TestThread()
        {
            //create child threads
            //Thread t1=new Thread(new ThreadStart(Print1));
            //Thread t1 = new Thread(print1);
            //Thread t2 = new Thread(print2);
            Thread t1 = new Thread(new ThreadStart(print1));
            Thread t2 = new Thread(new ThreadStart(print2));
            t1.Start();
            t2.Start();
            Thread t3 = new Thread(print3);
            t3.Start();
            Thread t4 = new Thread(print4);
            t4.Start();

            Console.ReadLine();
        }
    }
}
