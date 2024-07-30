using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionProject
{
    class HashTableStudent
    {
        int rollNo;
        String name;
        String subs;

        public HashTableStudent(int rn, String name,String sub)
        {
            this.rollNo = rn;
            this.name = name;
            this.subs = sub;
        }

        public int RollNumber
        {
            get { return this.rollNo; }
        }

        public override String ToString() 
        {
            return "Roll No:" + this.rollNo + ",Name:" + this.name +",Subject:" + this.subs ;
        }

        public String GetSubjects()
        {
            return this.subs ;
        }

    }
}
