using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Arithmetic
    {
        int a, b;
        public void AddNumbers(int a, int b)
        {
            a = a + b;
            Console.WriteLine(a);
        }
        public void MultiplyNumbers(int a, int b)
        {
            a = a * b;
            Console.WriteLine(a);
        }
    }
}
