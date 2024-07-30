using System;

namespace ConsoleApp2
{
    internal class ArithmeticOperations
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            int c = a + b;
            Console.WriteLine("Addition: " + c);
            c = a - b;
            Console.WriteLine("Subtraction: " + c);
            c = a / b;
            Console.WriteLine("Division: " + c);
            c = a * b;
            Console.WriteLine("Multiplication: " + c);
        }
    }
}
