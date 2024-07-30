using System;

namespace ConsoleApp2
{
    internal class JaggedArray
    {
        public static void Main(string[] args)
        {
            string[][] companies = new string[3][];
            companies[0] = new string[] { "Intel", "AMD" };
            companies[1] = new string[] { "IBM", "Microsoft", "Sun" };
            companies[2] = new string[] { "HP", "Canon", "Lexmark", "Epson" };

            for (int i = 0; i < companies.Length; i++)
            {
                for (int j = 0; j < companies[i].Length; j++)
                {
                    Console.Write(companies[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
