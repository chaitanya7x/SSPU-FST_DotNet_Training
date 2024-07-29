using System;

namespace ConsoleApp2.Inheritance
{
    class GrandFather
    {
        public int Id = 9;
        public void Display()
        {
            Console.WriteLine($"Display {Id}");
            Console.WriteLine("I am GrandFather");
        }
    }

    class Father : GrandFather
    {
        public void Show()
        {
            Console.WriteLine("I am Father");
        }
    }

    class Son : Father
    {
        public void Print()
        {
            Console.WriteLine("I am Son");
        }
    }
}
