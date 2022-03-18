using System;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex" };
            int[] vect1 = new int[] { 1, 2, 3 };


            foreach(string obj in vect)
            {
                Console.WriteLine(obj);
            }

            foreach (int obj in vect1)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
