using System;

namespace ConsoleApp2
{
    internal class TwoDArray
    {
        public static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            Console.WriteLine("Enter 9 numbers:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Array elements are:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
