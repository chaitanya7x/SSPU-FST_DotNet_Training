using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operations
            
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

            // User Input
            
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);
            

            // If-Else Statement
            
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            

            // Switch-Case Statement
            
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
            

            // For Loop
            
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is even");
                }
            }
            

            // While Loop
            
            int i = 10;
            while (i % 2 == 0 && i >= 0)
            {
                Console.WriteLine(i + " is even");
                i--;
            }
            

            // Two-Dimensional Array
            
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
            

            // Jagged Array
            
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
            

            // Employee Class
            
            Employee emp = new Employee();
            emp.GetDetails();
            emp.CalculateGrossSalary();
            emp.CalculateNetSalary();
            

            // Circle Class

            Circle circle = new Circle();
            circle.Area();
            

            // Inheritance Example

            DerivedClass obj = new DerivedClass();
            obj.Display();
            obj.Show();
            

            // Interface Example

            IAnimal animal = new Dog();
            animal.Sound();
            

            // Exception Handling Example

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
