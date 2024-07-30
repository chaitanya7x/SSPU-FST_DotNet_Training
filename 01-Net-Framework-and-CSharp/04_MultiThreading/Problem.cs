using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Problem
    {
        static int range;
        
        public static void Even()
        {
            Console.WriteLine("Even Numbers");
            for (int i = 0; i <= range; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(" "+ i);
                }
            }
        }
        public static void Odd()
        {
            Console.WriteLine("Odd Numbers");
            for (int i = 0; i <= range; i++)
            {
                
                if (i % 2 != 0)
                {
                    Console.WriteLine(" " + i);
                }
            }
        }
        public static void print()
        {
            Console.WriteLine("Enter the Range : ");
            range = Convert.ToInt32(Console.ReadLine());

            Thread t1 = new Thread(Even);
            Thread t2 = new Thread(Odd);
            
            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
        }

    }
}
