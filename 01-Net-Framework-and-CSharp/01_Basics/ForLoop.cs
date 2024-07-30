using System;

namespace ConsoleApp2
{
    internal class ForLoop
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is even");
                }
            }
        }
    }
}
