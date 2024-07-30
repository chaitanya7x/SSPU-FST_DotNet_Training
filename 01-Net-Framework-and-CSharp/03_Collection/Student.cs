using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class Student
    {
        public delegate void RollCheck();
        static ArrayList studentList = new ArrayList();
        int age, rollNo, ch;
        String name, address;
        public event RollCheck RollNumberChecked;

        //    int rollNo;
        //    String name;

        //    public Student(int rollNo, String name)
        //    {
        //        this.rollNo = rollNo;
        //        this.name = name;
        //    }

        //    public override string ToString()
        //    {
        //        return "Name " + this.name;
        //    }

        public Student(int age, int rollNo, String name, String address)
        {
            this.age = age;
            this.rollNo = rollNo;
            this.name = name;
            this.address = address;
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (this.age > 18)
                    this.RollNumberChecked();

                this.age = value;
            }
        }

        public void GetValue()
        {
            Console.WriteLine("Enter the Name :");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter the Address :");
            address = Console.ReadLine();
            Console.WriteLine("Enter the Name :");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name :");
            rollNo = Convert.ToInt32(Console.ReadLine());

            if (this.age > 18)
            {
                studentList.Add(new Student(this.age, this.rollNo, this.name, this.address));
                Console.WriteLine("Student added to the list.");
            }
            else
            {
                Console.WriteLine("Age is not greater than 18. Student not added.");
            }



        }
    }
}
