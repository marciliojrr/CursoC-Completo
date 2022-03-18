using System;

namespace PropDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayofYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("18) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeofDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine("\n--- FORMATACAO ---");

            Console.WriteLine(d.ToLongDateString()); // quarta-feira, 15 de agosto de 2001
            string s1 = d.ToLongDateString();
            Console.WriteLine(s1); // quarta-feira, 15 de agosto de 2001

            string s2 = d.ToLongTimeString();
            Console.WriteLine(s2);
            
            string s3 = d.ToShortDateString();
            Console.WriteLine(s3);

            string s4 = d.ToShortTimeString();
            Console.WriteLine(s4);

            string s5 = d.ToString();
            Console.WriteLine(s5);

            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s6);

            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff"); // 2001-08-15 13:45:58.275
            Console.WriteLine(s7);

            Console.WriteLine("\n--- OPERACOES ---");

            DateTime d2 = d.AddHours(2);
            Console.WriteLine(d);
            Console.WriteLine(d2);

            DateTime d3 = d.AddMinutes(3);
            Console.WriteLine(d3);

            TimeSpan t = d2.Subtract(d); // Diferenca de datas
            Console.WriteLine(t);
        }
    }
}
