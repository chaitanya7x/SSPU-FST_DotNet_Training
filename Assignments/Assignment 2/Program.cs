using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public static void Main(string[] args)
    {
        Person[] persons = new Person[]
           {
            new Person("Chaitanya", 30),
            new Person("om", 25),
            new Person("john", 35)
           };

        Console.WriteLine("Before sorting:");
        foreach (var p1 in persons)
        {
            p1.PrintDetails();
        }

        Array.Sort(persons);

        Console.WriteLine("\nAfter sorting:");
        foreach (var p2 in persons)
        {
            p2.PrintDetails();
        }
    }
}