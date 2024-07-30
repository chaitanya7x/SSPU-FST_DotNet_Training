using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class Sort
    {
        public static void sort()
        {
            //#region By Manual Method INT
            int[] arr = new int[3];

            int count = 0;
            int temp = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Enter the array for {0} th element:", count);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //    count = count + 1;
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}

            //Console.WriteLine("Sorted Array :");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("{0}", arr[i]);
            //}
            //#endregion

            #region
            String[] arr1 = new String[3];
            count = 0;
            temp = 0;

            for (int i = 0;i < arr1.Length; i++)
            {
                Console.WriteLine("Enter the array for {0} th String element:", count);
                arr1[i] = Console.ReadLine();
                count = count + 1;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                }
            }

            Console.WriteLine("Sorted String Array :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}", arr1[i]);
            }
            #endregion

            //#region By built in Method
            //Console.WriteLine("By Built-In Methods");
            //Array.Sort(arr);
            //Array.Sort(arr1);
            //foreach(int i in arr) { Console.WriteLine("{0}",i); }
            foreach(String i in arr1) { Console.WriteLine("{0}",i); }
            //#endregion
        }
    }
}
