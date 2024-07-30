using System;

namespace ConsoleApp2
{
    interface IAnimal
    {
        void Sound();
    }

    class Dog : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    class InterfaceExample
    {
        public static void Main(string[] args)
        {
            IAnimal animal = new Dog();
            animal.Sound();
        }
    }
}
