using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // P_1
            Arithmetic a1 = new Arithmetic();
            a1.AddNumbers(10, 20);
            a1.MultiplyNumbers(20, 10);

            Console.ReadKey();
            // P_3
            Arithmetic a2 = new Arithmetic();

            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an operation: 1. Addition 2. Multiplication 3. Both");
            int choice = Convert.ToInt32(Console.ReadLine());

            Operation op = null;

            switch (choice)
            {
                case 1:
                    op = new Operation(a2.AddNumbers);
                    break;
                case 2:
                    op = new Operation(a2.MultiplyNumbers);
                    break;
                case 3:
                    op = new Operation(a2.AddNumbers);
                    op += a2.MultiplyNumbers;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
            op.Invoke(num1,num2);
        }
    }
}
