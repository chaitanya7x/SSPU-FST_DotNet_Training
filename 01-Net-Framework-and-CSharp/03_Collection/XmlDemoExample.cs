using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CollectionProject
{

    public class stud
    {
        [XmlAttribute("RollNo")]
        public int Rno { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Marks")]
        public double Marks { get; set; }

        [XmlIgnore]
        public int Otp { get; set; }
    }

    class XmlDemo
    {
        public static void testXml()
        {
            stud s1 = new stud
            {
                Rno = 1,
                Name = "Chaitanya",
                Marks = 1000,
                Otp = 2376
            };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(stud));
            using (StreamWriter writer = new StreamWriter(@"E:\Serializable.xml"))
            {
                xmlSerializer.Serialize(writer, s1);
            }

            using (StreamReader reader = new StreamReader(@"E:\Serializable.xml"))
            {
                stud s2 = (stud)xmlSerializer.Deserialize(reader);
                Console.WriteLine("Roll No.: {0}", s2.Rno);
                Console.WriteLine("Name: {0}", s2.Name);
                Console.WriteLine("Marks: {0}", s2.Marks);

            }
        }
    }

}

