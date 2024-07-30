using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class StackProgram
    {
        public static void stackEx()
        {
            Console.WriteLine("-------stack demo--------");
            Stack stkobj = new Stack();
            stkobj.Push(100);
            stkobj.Push(3.12f);
            stkobj.Push("okuuk");

            Console.WriteLine("Initially Stack has: {0} Objects",stkobj.Count);

            Console.WriteLine("\n Iterating elements in a stack using foreach");

            foreach(object obj in stkobj)
            {
                Console.WriteLine("{0}",obj);
            }
            Console.WriteLine("After foreach Stack has: {0} Objects", stkobj.Count);
            Console.WriteLine("\n\n Iterating Elements in a stack using while");

            object objcurrent;
            while (stkobj.Count > 0) { 
                objcurrent = stkobj.Pop();
                Console.WriteLine("{0}",objcurrent);
            }
            Console.WriteLine("After pop Stack has: {0} Objects", stkobj.Count);
        }
    }
}
