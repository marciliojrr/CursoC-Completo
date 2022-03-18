using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotacao do dolar? ");
            double cotDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares voce vai comprar? ");
            double qtdCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.ConverteDolar(cotDolar, qtdCompra).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
