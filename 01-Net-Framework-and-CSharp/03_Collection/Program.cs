using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sort
            Sort.sort();

            // ArrayList Program
            ArrayListProgram.arrayList();

            // Sorted List Program
            SortedListProgram.sortedlistprog();

            // Stack Program
            StackProgram.stackEx();

            // Student Main Method
            Student.main();

            // Queue Program
            QueueProgram.queue();

            // Problem Data Methods
            Problem.GetData();
            Problem.print();

            // New Student Test Method
            NewStudent.testStud();

            // Clone Example Test Method
            CloneExample.testCloneEmp();

            // Equal Example Test Method
            EqualExample.testEqualStud();

            // HashTableStudent Instances and Hashtable Operations
            HashTableStudent hs1 = new HashTableStudent(12, "chaitanya", "math , Science, PT");
            HashTableStudent hs2 = new HashTableStudent(13, "chaitanya", "math , pom, dom");
            HashTableStudent hs3 = new HashTableStudent(14, "chaitanya", "math , tom, goa");
            HashTableStudent hs4 = new HashTableStudent(15, "chaitanya", "math , arts, c#");
            HashTableStudent hs5 = new HashTableStudent(16, "chaitanya", "math , rust, C");
            HashTableStudent hs6 = new HashTableStudent(17, "chaitanya", "math , rust, C");

            Hashtable htStudent = new Hashtable(5);
            Console.WriteLine("Hashtable Count after Creation: {0}", htStudent.Count);

            htStudent.Add(hs1.RollNumber, hs1);
            htStudent.Add(hs2.RollNumber, hs2);
            htStudent.Add(hs3.RollNumber, hs3);
            htStudent.Add(hs4.RollNumber, hs4);
            htStudent.Add(hs5.RollNumber, hs5);
            htStudent.Add(hs6.RollNumber, hs6);

            Console.WriteLine("Hashtable Count After Adding the Elements: {0}", htStudent.Count);

            // Searching by RollNo
            Console.WriteLine("Enter the Roll No to Search From Record : ");
            int rollno = Convert.ToInt32(Console.ReadLine());

            object searchResult = htStudent[rollno];

            if (searchResult == null)
            {
                Console.WriteLine("Student With Roll No.:{0} is not Present", rollno);
            }
            else
            {
                // Student studentfound = (Student)searchResult;
                HashTableStudent studentfound = searchResult as HashTableStudent;
                Console.WriteLine("Student Found, Student Details:\n{0}", studentfound);
            }

            // Iteration over Keys in Hashtable
            Console.WriteLine("\n\n Roll No present in student table:");
            foreach (object i in htStudent.Keys)
            {
                Console.WriteLine("{0}", i);
            }

            // Iteration over Values in Hashtable
            Console.WriteLine("\n\n Student Present in Student Table:");
            foreach (object obj in htStudent.Values)
            {
                // Console.WriteLine("\n\n{0},\n Subject Chosen:{1}", obj, ((HashTableStudent)obj).GetSubjects());
                Console.WriteLine("\n\n{0},\n Subject Chosen:{1}", obj, (obj as HashTableStudent).GetSubjects());
            }

            // Iteration Over Keys and Values in Hashtable
            Console.WriteLine("\n\n Iterating Both Keys and Values:");
            foreach (DictionaryEntry de in htStudent)
            {
                Console.WriteLine("\nKey:{0}, Value{1}", de.Key, de.Value);
            }

            // Customer Test Method
            Customer.testCustomer();

            // Generic Swap Examples
            int a = 10;
            int b = 20;

            Console.WriteLine($"Before swap: a = {a}, b = {b}");
            GenericExample.Swap(ref a, ref b);
            Console.WriteLine($"After swap: a = {a}, b = {b}");

            Console.WriteLine();

            string x = "Hello";
            string y = "World";

            Console.WriteLine($"Before swap: x = {x}, y = {y}");
            GenericExample.GetSwap(ref x, ref y);
            Console.WriteLine($"After swap: x = {x}, y = {y}");

            // Generic Example with Swap Method
            GenericExample1<int> e1 = new GenericExample1<int>(30, 20);
            e1.swap();
            GenericExample1<string> e2 = new GenericExample1<string>("Hello", "World");
            e2.swap();
            Console.WriteLine(e1.X + " " + e1.Y);
            Console.WriteLine(e2.X + " " + e2.Y);
            Console.ReadLine();

            // Generic Problem Array Example
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            GenericProblemArray<string> stringArray = new GenericProblemArray<string>(size);
            stringArray.GetArray();
            stringArray.PrintArray();

            GenericProblemArray<int> intArray = new GenericProblemArray<int>(size);
            intArray.GetArray();
            intArray.PrintArray();

            GenericProblemArray<double> doubleArray = new GenericProblemArray<double>(size);
            doubleArray.GetArray();
            doubleArray.PrintArray();

            // Reflection Example
            reflectionExample.getInfo();

            // Serialization Demo
            seralizationDemo.testSerialization();

            // Display Example
            Display.display();

            // XML Demo
            XmlDemo.testXml();
        }
    }
}
