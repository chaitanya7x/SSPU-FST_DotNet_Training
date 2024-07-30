using System;
using System.IO;

namespace File_Handling
{
    public delegate void RollDelegate();
    class Student
    {
        int age;
        int rollNo;
        String name;
        public event RollDelegate RollNumberChanged;

        public Student(int Age, int RollNo, String Name)
        {
            this.age = Age;
            this.rollNo = RollNo;
            this.name = Name;
        }

        public void print()
        {
            Console.WriteLine(name);
            Console.WriteLine(rollNo);
            Console.WriteLine(age);
        }

        public int Roll
        {
            get { return this.rollNo; }
            set
            {
                if (this.RollNumberChanged != null)
                    this.RollNumberChanged();
                this.rollNo = value;
            }
        }

        public static void LogChanges()
        {
            StreamWriter writer = new StreamWriter("changes.txt");
            writer.WriteLine("Roll No Changed");
            writer.Close();
        }
    }
}
