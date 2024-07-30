using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionProject
{
    class Problem
    {
        static String[] fname = new string[2];
        static String[] sname = new string[2];
        

        public static void GetData()
        {
            int count = 1;
            for (int i = 0; i < fname.Length; i++)
            {
                
                Console.WriteLine("Enter the {0} Record :", count);
               
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("Enter the First Name :");
                    fname[i] = Console.ReadLine();
                    Console.WriteLine("Enter the Last Name :");
                    sname[j] = Console.ReadLine();
                    count=count+1;
                }
            }
        }

        public static void print()
        {
            int count = 1;
            for (int i = 0; i < fname.Length; i++)
            {
                Console.WriteLine("\n {0} Record :", count);
                for (int j = 0; j < sname.Length-1; j++)
                {
                    
                    Console.Write("\n"+ fname[i] + " " + sname[j]);
                }
                count++;
            }
        }

        public static void display(String[] fname, String[] sname)
        {

        }
    }

}
