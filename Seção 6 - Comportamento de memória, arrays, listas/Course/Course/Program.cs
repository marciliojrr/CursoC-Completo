using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p); // Output: (10, 20)

            p = new Point();
            Console.WriteLine(p); // Output: (0, 0)
            */

            //double x = null; // ERRO. Pois struct nao pode receber null

            /*
            Nullable<double> x = null;
            // double? x = null; // Declaracao mais simples de um Nullable
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); //Pega o valor definido ou o valor padrao do tipo
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); // Output: false
            Console.WriteLine(y.HasValue); // Output: true

            //Console.WriteLine(x.Value); // ERRO. Sera lancada uma excecao.

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }
            */

            // ?? = operador de coalescencia
            double? x = null;
            double? y = 10.00;

            double a = x ?? 5; // se x for null, x recebe o valor 5
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
