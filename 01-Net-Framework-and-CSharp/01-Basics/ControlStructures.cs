using System;

namespace ControlStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the No: ");
            int no = Convert.ToInt32(Console.ReadLine());
            if (no % 2 == 0)
            {
                Console.WriteLine("NO is even");
            }
            else
            {
                Console.WriteLine("NO is odd");
            }

            Console.Write("Enter the Alphabet: ");
            Char Alphabet = Convert.ToChar(Console.ReadLine());

            if (Alphabet == 'A' || Alphabet == 'E' || Alphabet == 'I' || Alphabet == 'O' || Alphabet == 'U')
            {
                Console.WriteLine("{0} is vowel", Alphabet);
            }
            else
            {
                Console.WriteLine("{0} is Consonants", Alphabet);
            }
        }
    }
}
