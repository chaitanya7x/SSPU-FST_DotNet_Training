using System;

namespace ConsoleApp2
{
    public class Circle
    {
        public void Area()
        {
            const double pi = 3.14;
            double r = 7;
            double area = pi * r * r;
            Console.WriteLine("Area of Circle: " + area);
        }
    }
}
