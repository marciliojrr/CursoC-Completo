using System;
using System.Globalization;

namespace Course
{
    internal class EntradaDeDados1
    {
        static void Main(string[] args)
        {
            // Calculo de area de triangulo sem usar POO
            /*
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine($"Area de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
            */

            // Utilizando Classes

            /*
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine($"Area de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
            */
            Console.WriteLine("EXERCICIO 1 - CLASSE PESSOA");

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }

            Console.WriteLine("EXERCICIO 2 - CLASSE FUNCIONARIO");

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine($"Salario medio = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
