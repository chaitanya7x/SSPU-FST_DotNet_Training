using System;

namespace ObjectOriented
{
    class Circle
    {
        const double Pi = 3.14;
        double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public void Area()
        {
            double area = Pi * radius * radius;
            Console.WriteLine("Area of Circle: " + area);
        }
    }
}
