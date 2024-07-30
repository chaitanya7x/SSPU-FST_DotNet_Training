using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class StudentEqual : IEquatable<StudentEqual>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Program { get; set; }

        public bool Equals(StudentEqual otherStduent)
        {
            //if (this.ID == otherStduent.ID) { return true; }
            //else if (this.Name == otherStduent.Name) { return true; }
            //else { return false; }

            return (this.ID == otherStduent.ID || this.Name == otherStduent.Name);
            //return (this.ID == otherStduent.ID && this.Name == otherStduent.Name);
        }
    }
    class EqualExample
    {
        public static void testEqualStud()
        {
            var s1 = new StudentEqual { ID = 1, Name = "Chaitanya", Program = "MCA" };
            var s2 = new StudentEqual { ID = 2, Name = "C", Program = "MCA" };
            var s3 = new StudentEqual { ID = 1, Name = "Chaitanya", Program = "MCA" };

            var s1s2 = s1.Equals(s2);
            var s2s3 = s1.Equals(s3);

            Console.WriteLine($"Student 1 is Equal to Student 2 - {s1s2}");
            Console.WriteLine($"Student 1 is Equal to Student 3 - {s2s3}");
        }
    }
}
