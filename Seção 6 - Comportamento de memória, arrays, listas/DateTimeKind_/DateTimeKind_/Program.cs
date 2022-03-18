using System;

namespace DateTimeKind_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 08, 15, 13, 05, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 08, 15, 13, 05, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 08, 15, 13, 05, 58);

            Console.WriteLine($"d1: {d1}");
            Console.WriteLine($"d1 Kind: {d1.Kind}");
            Console.WriteLine($"d1 to Local: {d1.ToLocalTime()}");
            Console.WriteLine($"d1 to Utc: {d1.ToUniversalTime()}");

            Console.WriteLine("\n");

            Console.WriteLine($"d2: {d2}");
            Console.WriteLine($"d2 Kind: {d2.Kind}");
            Console.WriteLine($"d2 to Local: {d2.ToLocalTime()}");
            Console.WriteLine($"d2 to Utc: {d2.ToUniversalTime()}");

            Console.WriteLine("\n");

            Console.WriteLine($"d3: {d3}");
            Console.WriteLine($"d3 Kind: {d3.Kind}");
            Console.WriteLine($"d3 to Local: {d3.ToLocalTime()}");
            Console.WriteLine($"d3 to Utc: {d3.ToUniversalTime()}");

            Console.WriteLine("\n");

            // PADRAO ISO 8601

            Console.WriteLine("PADRAO ISO 8601");

            DateTime d = DateTime.Parse("2000-08-15 13:05:58");
            DateTime _d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine($"d: {d}");
            Console.WriteLine($"d Kind: {d.Kind}");
            Console.WriteLine($"d to Local: {d.ToLocalTime()}");
            Console.WriteLine($"d to Utc: {d.ToUniversalTime()}");
            
            Console.WriteLine();

            Console.WriteLine($"_d2: {_d2}");
            Console.WriteLine($"_d2 Kind: {_d2.Kind}");
            Console.WriteLine($"_d2 to Local: {_d2.ToLocalTime()}");
            Console.WriteLine($"_d2 to Utc: {_d2.ToUniversalTime()}");

            Console.WriteLine();

            Console.WriteLine(_d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // Cuidado. Pode dar erro.
            Console.WriteLine(_d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); // Mais correto

        }
    }
}
