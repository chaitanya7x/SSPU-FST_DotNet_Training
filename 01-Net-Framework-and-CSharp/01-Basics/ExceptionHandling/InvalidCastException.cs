using System;

namespace ConsoleApp2.ExceptionHandling
{
    class InvalidCastExceptionExample
    {
        public static void TestException()
        {
            try
            {
                Object obj = "the";
                int i = (int)obj;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
