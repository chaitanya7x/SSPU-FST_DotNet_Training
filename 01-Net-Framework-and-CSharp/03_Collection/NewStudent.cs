using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject 
{
    public class NewStudent:IComparable<NewStudent> 
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public NewStudent(String name, int age, int marks)
        {
            Name = name;
            Marks = marks;
            Age = age;
        }

        public int CompareTo(NewStudent other)
        {
            if (this.Age > other.Age) { return 1; }
            else if (this.Age < other.Age) { return -1; }
            else { return 0; }
        }
        public int Compare(NewStudent x, NewStudent y)
        {
            if (x.Marks < y.Marks) { return 1; }
            else if (x.Marks > y.Marks) { return -1; }
            else { return 0; }
        }

        public static void testStud()
        {
            List<NewStudent> StudList = new List<NewStudent>();
            var s1 = new NewStudent("ravindra",10,21);
            var s2 = new NewStudent("komal2",637,252);
            var s3 = new NewStudent("om",928,23);
            

            StudList.Add(s1);
            StudList.Add(s2);
            StudList.Add(s3);

            StudList.Sort();


            Console.WriteLine("Sorting");
            foreach (NewStudent s in StudList)
            {
                Console.WriteLine(s.ToString());
            }
            Console.ReadKey();
            Console.WriteLine("Reverse");
            StudList.Reverse();

            foreach (NewStudent s in StudList)
            {
                Console.WriteLine(s.ToString());
            }
            
        }


        public override String ToString()
        {
            return "Name = " + Name + " Marks = " + Marks + " Age = " + Age;
        }

    }
}
