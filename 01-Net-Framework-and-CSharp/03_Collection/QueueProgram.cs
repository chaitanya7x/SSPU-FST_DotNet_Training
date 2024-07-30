using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class QueueProgram
    {
        public static void queue()
        {
            Console.WriteLine("------Queue Demo------");
            Queue objque = new Queue();
            objque.Enqueue(101);
            objque.Enqueue(3.23f);
            objque.Enqueue("avav");

            Console.WriteLine("Initially Queue has: {0} Objects", objque.Count);

            Console.WriteLine("\n Iterating elements in a Queue using foreach");

            foreach (object obj in objque)
            {
                Console.WriteLine("{0}", obj);
            }

            Console.WriteLine("After foreach Queue has: {0} Objects", objque.Count);
            Console.WriteLine("\n\n Iterating Elements in a Queue using while");

            object objcur1;

            while (objque.Count > 0)
            {
                objcur1 = objque.Dequeue();
                Console.WriteLine("{0}", objcur1);
            }
            Console.WriteLine("After Dequeue Queue has: {0} Objects", objque.Count);

        }
    }
}
