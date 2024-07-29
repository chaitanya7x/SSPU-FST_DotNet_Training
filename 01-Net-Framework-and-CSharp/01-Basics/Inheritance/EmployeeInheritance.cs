using System;

namespace ConsoleApp2.Inheritance
{
    class EmployeeInheritance : Manager
    {
        public new void PersonalDetails()
        {
            Console.WriteLine("Enter the Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Age:");
            int age = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            PersonalDetails();
            ProjectDetails();
        }
    }
}
