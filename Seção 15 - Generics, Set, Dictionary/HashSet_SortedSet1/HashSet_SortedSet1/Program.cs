using System;
using System.Collections.Generic;

namespace HashSet_SortedSet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            foreach (string s in set) 
            { 
                Console.WriteLine(s); 
            }
        }
    }
}
