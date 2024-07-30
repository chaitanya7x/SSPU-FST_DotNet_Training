using System;

namespace ConsoleApp2
{
    class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("Display method in BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public void Show()
        {
            Console.WriteLine("Show method in DerivedClass");
        }
    }

    class InheritanceExample
    {
        public static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.Display();
            obj.Show();
        }
    }
}
