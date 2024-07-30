using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class ArrayListProgram
    {
        public static void arrayList()
        {
            ArrayList a = new ArrayList();
            //ArrayList<String> b = new ArrayList<String>();

            a.Add(100);
            a.Add(200);
            a.Add(300);
            a.Add("Chaitanya");
            a.Add("Mate");
            a.Add("------------");
            Console.WriteLine("Array Contains = ");
            foreach (object i in a) { Console.WriteLine(i.ToString()); }

            a.Remove(100);
            Console.WriteLine("Array After Remove function use = ");
            foreach (object i in a) { Console.WriteLine(i.ToString()); }

            a.Insert(0,"xyz");
            Console.WriteLine("Array After Insert function use = ");
            foreach (object i in a) { Console.WriteLine(i.ToString()); }

            //a.Add(new Student(12,"caycua"));
            //a.Add(new Student(12,"caycua"));
            //a.Add(new Student(12,"caycua"));
            //a.Add(new Student(12,"caycua"));
            //a.Add(new Student(12,"caycua"));
            foreach (object i in a) { Console.WriteLine(i.ToString()); }
        }
    }
}
