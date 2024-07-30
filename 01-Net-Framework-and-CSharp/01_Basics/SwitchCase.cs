using System;

namespace ConsoleApp2
{
    internal class SwitchCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character:");
            char ch = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (ch)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("{0} is a vowel", ch);
                    break;
                default:
                    Console.WriteLine("{0} is a consonant", ch);
                    break;
            }
        }
    }
}
