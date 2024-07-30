using System;

namespace File_Handling
{
    class Problem1
    {
        public static void RevString()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            int length = input.Length;
            Console.WriteLine("Length of the string: " + length);

            char[] charArray = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                charArray[i] = input[input.Length - 1 - i];
            }

            string reversed = new string(charArray);
            Console.WriteLine("Reversed string: " + reversed);

            if (input == reversed)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }

        class Problem2
        {
            public static void AnagramCheck()
            {
                Console.WriteLine("Enter the first string:");
                string firstString = Console.ReadLine();

                Console.WriteLine("Enter the second string:");
                string secondString = Console.ReadLine();

                if (AreAnagrams(firstString, secondString))
                {
                    Console.WriteLine("The strings are anagrams.");
                }
                else
                {
                    Console.WriteLine("The strings are not anagrams.");
                }
            }

            static bool AreAnagrams(string str1, string str2)
            {
                if (str1.Length != str2.Length)
                {
                    return false;
                }

                char[] charArray1 = str1.ToLower().ToCharArray();
                char[] charArray2 = str2.ToLower().ToCharArray();
                Array.Sort(charArray1);
                Array.Sort(charArray2);

                for (int i = 0; i < charArray1.Length; i++)
                {
                    if (charArray1[i] != charArray2[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
