using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Person
    {
        string name;
        int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void student(String name,int age)
        {
            name = name;
            age = age;
        }
        public void canVote()
        {
            if (this.age >= 18)
            {
                Console.WriteLine("Name: {0} \n Age: {1}", name, age);
                Console.WriteLine("You are Eligible Voter");
            }
            else
            {
                Console.WriteLine("You are not the Elgible Voter");
            }
        }
    }
}
