using System;
using System.Globalization;

namespace SpecialTopics1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inferencia de tipos: palavra var
            var k = 10; // declara uma variavel que tera seu tipo inferido de acordo com o valor dela
            var y = 20.0;
            var z = "Maria";

            // 'var' e comodo, mas pode abrir brechas para erros

            Console.WriteLine(k);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // switch-case
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine($"Day: {day}");

            // Expressao condicional ternaria
            // Sintaxe: (condicao) ? valor_se_verdadeiro : valor_se_falso
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double discount = (price < 20.0) ? price * 0.1 : price * 0.05;

            Console.WriteLine(discount);
        }
    }
}
