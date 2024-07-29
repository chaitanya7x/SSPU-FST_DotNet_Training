using System;

namespace ObjectOriented
{
    class Car
    {
        public string model;
        public string color;
        public int year;

        public void DisplayCarInfo()
        {
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Year: " + year);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.model = "Mustang";
            car1.color = "Red";
            car1.year = 1969;

            car1.DisplayCarInfo();
        }
    }
}
