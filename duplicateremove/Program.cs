using System;
using System.Collections.Generic;

class Program
    {
        static List<string> RemoveDuplicate(List<string> list)
        {
            List<string> duplicate = new List<string>();

            foreach (string i in list)
            {
                if (!duplicate.Contains(i))
                {
                    duplicate.Add(i);
                }
            }

            return duplicate;
        }

        public static void Main(string[] args)
        {
            List<string> list = new List<string> { "apple", "banana", "vegeta", "nishant", "banana", "grape", "vegeta", "laptop", "apple" };

            Console.WriteLine("Original List:");
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }

            List<string> uniqueList = RemoveDuplicate(list);

            Console.WriteLine("\nList with Duplicates Removed:");
            foreach (string str in uniqueList)
            {
                Console.WriteLine(str);
            }
        }
    }
