using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{

    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public int CompareTo(Person other)
        {
            if (this.Age > other.Age)
            {
                return 1;
            }
            else if (this.Age < other.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}