using System;

namespace ConsoleApp2
{
    internal class UserInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);
        }
    }
}
