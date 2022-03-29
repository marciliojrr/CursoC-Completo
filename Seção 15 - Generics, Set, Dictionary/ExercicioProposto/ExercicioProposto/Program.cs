using ExercicioProposto.Entities;
using System;
using System.Collections.Generic;

namespace ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Course A
            HashSet<Students> a = new HashSet<Students>();
            Console.Write("How many students for course A? ");
            int nA = int.Parse(Console.ReadLine());

            for (int i = 0; i < nA; i++)
            {
                a.Add(new Students { RegistrationNumber = int.Parse(Console.ReadLine()) });
            }

            // Course B
            HashSet<Students> b = new HashSet<Students>();
            Console.Write("How many students for course B? ");
            int nB = int.Parse(Console.ReadLine());

            for (int i = 0; i < nB; i++)
            {
                b.Add(new Students { RegistrationNumber = int.Parse(Console.ReadLine()) });
            }

            // Course C
            HashSet<Students> c = new HashSet<Students>();
            Console.Write("How many students for course C? ");
            int nC = int.Parse(Console.ReadLine());

            for (int i = 0; i < nC; i++)
            {
                c.Add(new Students { RegistrationNumber = int.Parse(Console.ReadLine()) });
            }

            HashSet<Students> students = new HashSet<Students>(a);
            students.UnionWith(b);
            students.UnionWith(c);

            Console.Write($"Total students: {students.Count}");
            
        }
    }
}
