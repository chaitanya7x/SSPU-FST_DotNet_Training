using System;

namespace ConsoleApp2.Models
{
    class ReferenceVariable
    {
        public void SwapByValue(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Inside SwapByValue: a = " + a + ", b = " + b);
        }

        public void SwapByReference(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Inside SwapByReference: a = " + a + ", b = " + b);
        }
    }
}
