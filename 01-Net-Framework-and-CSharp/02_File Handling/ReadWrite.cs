using System;
using System.IO;

namespace File_Handling
{
    public static class ReadWrite
    {
        public static void readwrite()
        {
            BinaryWriter objWrite = new BinaryWriter(File.Create("E:/hello.txt"));
            Byte b = 25;
            int number = 1000;
            String name = "Chaitanya Mate";

            objWrite.Write(b);
            objWrite.Write(name);
            objWrite.Write(number);
            objWrite.Close();

            BinaryReader objRead = new BinaryReader(File.OpenRead("E:/hello.txt"));
            Byte b2 = objRead.ReadByte();
            String str2 = objRead.ReadString();
            int n = objRead.ReadInt16();

            Console.WriteLine("name = " + str2);
            Console.WriteLine("byte value = " + b2);
            Console.WriteLine("number = " + n);
            objRead.Close();
        }
    }
}
