using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class EmpClone : ICloneable
    {
        int age;
        public EmpClone(int width)
        {
            this.age = width;
        }
        public object Clone()
        {
            return new EmpClone(this.age);
        }

        public override string ToString() 
        {
            return String.Format("Emp Age = {0}",this.age);
        }
    }

    class CloneExample
    {
        public static void testCloneEmp()
        {
            EmpClone emp1=new EmpClone(1);
            EmpClone emp2=emp1.Clone() as EmpClone;

            Console.WriteLine("{0}mm", emp1);
            Console.WriteLine("{0}mm", emp2);
        }
    }

}
