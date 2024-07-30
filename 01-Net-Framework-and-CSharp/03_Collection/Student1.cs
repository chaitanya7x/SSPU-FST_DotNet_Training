using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class Student1
    {
        int age, id;
        String name;

        public Student1(int age, String name,int id)
        {
            this.age = age;
            this.name = name;
            this.id = id;
        }

        public static void testStud()
        {
            List<Student1> StudList = new List<Student1>();
            var s1 = new Student1(22, "jhhaitanya", 101);
            var s2 = new Student1(22, "cvsdavhaitanya", 101);
            var s3 = new Student1(22, "awchaitanya", 101);

            StudList.Add(s1);
            StudList.Add(s2);
            StudList.Add(s3);
            
            StudList.Sort();
            Console.ReadKey();


            foreach (var s in StudList)
            {
                Console.WriteLine(s.ToString());
            }
        }
        public override string ToString()
        {
            return "Name = " + this.name+ " ID = " + this.id + " Age = " + this.age;
        }
        interface IComparable { }
    }
}
