using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace rdbms
{
    class Program
    {
        static void Main(string[] args)
        {

            IList<student> studentList = new List<student>();
            IList<streams> streamsList = new List<streams>();

            studentList.Add(new student(101, "vijay", 22, 1));
            streamsList.Add(new streams(1, "abc"));

            //Console.WriteLine("Student List as Follows :- \n");
            //foreach (object s in studentList)
            //{
            //    Console.WriteLine(s.ToString());
            //    Console.WriteLine("\n");
            //}

            //Console.WriteLine("Streams List as Follows :- \n");
            //foreach (object s in streamsList)
            //{
            //    Console.WriteLine(s.ToString());
            //    Console.WriteLine("\n");
            //}

            var studentNames = studentList.Where(s => s.age > 20)
                .Select(s => s)
                .Where(s => s.streamID > 0)
                .Select(s => s.name);
            Console.ReadKey();
            Console.WriteLine("----------");

            var notValidStudentName = from s in studentList
                                      where s.age > 20 
                                      select new { name = s.name };

            notValidStudentName.ToList().ForEach(s => Console.WriteLine(s.name));
            //studentNames.ToList().ForEach(s => Console.WriteLine(s.name()));
            Console.ReadKey();
        }

    }
}