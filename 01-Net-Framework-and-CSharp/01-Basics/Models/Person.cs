using System;

namespace ConsoleApp2.Models
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void Student(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void CanVote()
        {
            if (_age >= 18)
            {
                Console.WriteLine($"Name: {_name} \n Age: {_age}");
                Console.WriteLine("You are an Eligible Voter");
            }
            else
            {
                Console.WriteLine("You are not an Eligible Voter");
            }
        }
    }
}
