using System;
using ExtensionMethods.Extensions;


namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DateTime Extensions");
            Console.WriteLine("-------------------");
            DateTime dt = new DateTime(2022, 03, 30, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
            Console.WriteLine();

            Console.WriteLine("String Extensions");
            Console.WriteLine("-----------------");
            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
