using System;
using ExtensionMethods.Extensions;


namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 03, 30, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
