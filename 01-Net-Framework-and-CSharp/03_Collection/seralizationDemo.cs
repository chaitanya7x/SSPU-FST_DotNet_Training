using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    [Serializable]
    class student
    {
        public int rno;
        public string name;
        public double marks;
        [NonSerialized()]
        public int otp;
    }
    class seralizationDemo
    {
        public static void testSerialization()
        {
            student s1 = new student();
            s1.rno = 1;
            s1.name = "Chaitanya";
            s1.marks = 1000;
            s1.otp = 2376;

            IFormatter f=new BinaryFormatter();
            Stream str = new FileStream(@"E:\Serealizable.txt", FileMode.Create, FileAccess.Write);
            f.Serialize(str,s1);
            str.Close();

            str = new FileStream(@"E:\Serealizable.txt",FileMode.Open,FileAccess.Read);
            student s2 = (student)f.Deserialize(str);

            Console.WriteLine("Roll No. {0}: ", s2.rno);
            Console.WriteLine("Name : {0}", s2.name);
            Console.WriteLine("Marks : {0}", s2.marks);


        }
    }
}
