using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace rdbms
{
    public class student
    {
        public int sid { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int streamID { get; set; }

        public student(int sid, string name, int age, int streamId)
        {
            this.sid = sid;
            this.name = name;
            this.age = age;
            this.streamID = streamId;
        }


        public override String ToString()
        {
            return "ID = " + sid + "\nName = " + name + "\nAge = " + age;
        }
    }

    public class streams
    {
        public  int streamId { get; set; }
        public  string sname { get; set; }

        public streams(int streamId, string sname)
        {
            this.streamId = streamId;
            this.sname = sname;
        }
        public override String ToString()
        {
            return "ID = " + streamId + "\nName = " + sname;
        }
    }

    //class LinqExample
    //{
    //    public static void example()
    //    {
    //        IList<studentLinq> studentList1 = new List<studentLinq>()
    //        {
    //            new studentLinq() {studentid=1,name="sunit",age=19,streamid=1},
    //            new studentLinq() {studentid=1,name="sunit",age=19,streamid=1},
    //            new studentLinq() {studentid=1,name="sunit",age=19,streamid=1};
    //        }
    //      
    //
    //    }
    //}
    
}
