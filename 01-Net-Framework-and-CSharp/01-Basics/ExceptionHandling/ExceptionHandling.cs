using System;

namespace ConsoleApp2.ExceptionHandling
{
    class ExceptionHandling
    {
        public static void Add()
        {
            int a = 10;
            int b = 0;
            int[] array = { 0, 4, 3 };

            try
            {
                Console.WriteLine(array[6]);
                int c = a / b;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
