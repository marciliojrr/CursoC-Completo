using System;
using System.Collections.Generic;

namespace HashSet_SortedSet2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // Union
            SortedSet<int> c = new SortedSet<int>(a); // Cria o SortedSet 'c', ja com os elementos de 'a'
            c.UnionWith(b); // Insere todos os elementos de 'b' que ainda nao estao em 'c'

            PrintCollection(c);

            // Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            PrintCollection(d);

            // Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            PrintCollection(e);

        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
