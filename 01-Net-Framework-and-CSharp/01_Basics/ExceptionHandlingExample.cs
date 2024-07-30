using System;

namespace ConsoleApp2
{
    class ExceptionHandlingExample
    {
        public static void Main(string[] args)
        {
            try
            {
                int a = 10, b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}
