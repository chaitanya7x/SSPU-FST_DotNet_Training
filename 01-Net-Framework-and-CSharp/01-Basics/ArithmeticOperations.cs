using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the B:");
            int B = Convert.ToInt32(Console.ReadLine());

            int C = A + B;
            Console.WriteLine("Addition = {0}", C);
            C = A - B;
            Console.WriteLine("Subtraction = {0}", C);
            C = A / B;
            Console.WriteLine("Division = {0}", C);
            C = A * B;
            Console.WriteLine("Multiplication = {0}", C);
        }
    }
}
