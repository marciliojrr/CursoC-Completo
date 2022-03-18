using System;
using System.Globalization;

namespace exercicio_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retangulo:");
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA = {r1.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {r1.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL= {r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("\n\n");

            Funcionario f1 = new Funcionario();

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();

            Console.Write("Salario bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(f1);

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentarSalario(porcentagem);

            Console.WriteLine($"Dados atualizados: {f1}");

            Console.WriteLine("\n\n");

            Aluno a1 = new Aluno();
            Aluno a2 = new Aluno();

            Console.Write("Nome do aluno: ");
            a1.Nome = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno:");
            a1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL =  {a1.NotaFinal()}");
            Console.WriteLine($"{a1.ResultadoFinal()}");

            Console.WriteLine("\n\n");

            Console.Write("Nome do aluno: ");
            a2.Nome = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno:");
            a2.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a2.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a2.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL =  {a2.NotaFinal()}");
            Console.WriteLine($"{a2.ResultadoFinal()}");
        }
    }
}
