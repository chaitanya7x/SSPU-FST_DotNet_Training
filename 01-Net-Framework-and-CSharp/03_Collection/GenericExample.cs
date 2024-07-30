using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class GenericExample
    {
        public static void Swap(ref int no1, ref int no2)
        {
            int temp = no1;
            no1 = no2;
            no2 = temp;
        }

        public static void GetSwap<T>(ref T element1, ref T element2)
        {
            T temp = element1;
            element1 = element2;
            element2 = temp;
        }
    }

    class GenericExample1<T>
    {
        T x; T y;

        public GenericExample1(T a, T b)
        {
            x = a; y = b;
        }

        public void swap()
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
        public T X
        {
            get { return x; }
            set { x = value; }
        }
        public T Y
        {
            get { return y; }
            set { y = value; }
        }
    }
    class GenericProblemArray<T>
    {
        static T[] array;

        public GenericProblemArray(int size)
        {
            array = new T[size];
        }

        public void GetArray()
        {
            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                string input = Console.ReadLine();
                }
            }
        
        public void PrintArray()
        {
            Console.WriteLine("Array elements are:");
            foreach (T element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}

