using System;
using System.IO;

namespace File_Handling
{
    public delegate void Calculate(int a);
    class Arithmetic
    {
        public static void square(int a)
        {
            a = a * a;
            Console.WriteLine("{0}", a);
        }

        public static void cube(int a)
        {
            a = a * a * a;
            Console.WriteLine("{0}", a);
        }

        public static void fourth(int a)
        {
            a = a * a * a * a;
            Console.WriteLine("{0}", a);
        }

        public static void fs(int a)
        {
            BinaryWriter objWrite = new BinaryWriter(File.Create("E:/hello.txt"));
            String name = "Chaitanya Mate";
            objWrite.Write(name);
            objWrite.Close();
        }
    }
}
