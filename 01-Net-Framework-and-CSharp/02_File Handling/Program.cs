using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    class Program
    {
        public delegate void demo1();
        public event demo1 myevent;

        static void Main(string[] args)
        {

            ReadWrite.readwrite();
            Problem1.RevString();
            DirectoryHandling.DirectoryDemo();

            // Delegate Example
            Console.WriteLine("Program to compute Square and Cube");
            Arithmetic objArith = new Arithmetic();
            Calculate bag = new Calculate(Arithmetic.square);
            bag += Arithmetic.cube;
            bag += Arithmetic.fourth;
            bag += Arithmetic.fs;
            Console.WriteLine("Result: ");
            bag.Invoke(2);

            // Event Example
            Program p = new Program();
            p.myevent += new demo1(Program1.disp);
            p.myevent += new demo1(Program1.show);
            p.myevent();

            // Student Event Example
            Student s1 = new Student(21, 101, "Chaitanya");
            s1.RollNumberChanged += Student.LogChanges;
            s1.print();
            Console.WriteLine();
            s1.Roll = 111;
            s1.print();
        }
    }
}
