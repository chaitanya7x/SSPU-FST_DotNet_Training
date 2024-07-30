using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class SortedListProgram
    {
        public static void sortedlistprog()
        {
            SortedList s = new SortedList();
            s.Add("john", "finance");
            s.Add("sallubhai", "actor");
            s.Add("ketan", "doctor");
            Console.WriteLine("Values = ");
            Console.WriteLine("Keys " + "\t" + "Values");
            Console.WriteLine("");
            for (int i = 0; i < s.Count; i++)
            {
                Console.WriteLine(s.GetKey(i) + "\t" + s.GetByIndex(i));
            }

            if (!s.ContainsKey("Aamir"))
            {
                s.Add("Amir", "HR");
            }
           
            s["ketan"] = "Marketing";
            Console.WriteLine("After Add =");
            for (int i = 0; i < s.Count; i++)
            {
                Console.WriteLine(s.GetKey(i) + "\t" + s.GetByIndex(i));
            }

        }
    }
}
