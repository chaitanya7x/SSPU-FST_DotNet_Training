using System;

namespace ConsoleApp2
{
    internal class WhileLoop
    {
        static void Main(string[] args)
        {
            int i = 10;
            while (i % 2 == 0 && i >= 0)
            {
                Console.WriteLine(i + " is even");
                i--;
            }
        }
    }
}
