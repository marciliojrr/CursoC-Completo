using System;
using System.Globalization;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // DateTime representa um instante

            // Pega data e hora atual do S.O
            DateTime d = DateTime.Now;
            Console.WriteLine(d);
            Console.WriteLine(d.Ticks); // Mostra os ticks desde a meia noite do dia 1 da era moderna

            // utilizando construtores
            DateTime d1 = new DateTime(2022, 11, 25); // Output: 25/11/2022
            Console.WriteLine(d1);

            DateTime d2 = new DateTime(2022, 11, 25, 20, 45, 03); // Output: 25 / 11 / 2022 20:45:03
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2022, 11, 25, 20, 45, 03, 500); // Output: 25 / 11 / 2022 20:45:03
            Console.WriteLine(d3);

            // utilizando builders
            DateTime d4 = DateTime.Now; // 17/03/2022 13:47:28
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Today; // 17/03/2022 00:00:00
            Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow; // 17 / 03 / 2022 16:48:19 - horario GMT (Greenwitch)
            Console.WriteLine(d6);

            // Usando o Parse para gerar datas
            DateTime d7 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d8);

            DateTime d9 = DateTime.Parse("15/08/2000");
            Console.WriteLine(d9);

            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d10);

            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);

            DateTime d12 = DateTime.ParseExact("2000-08-15 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine($"d12: {d12}");
        }
    }
}
