using System;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3]; // Cria e instancia uma matriz de duas linhas e tres colunas

            // Propriedades
            Console.WriteLine(mat.Length); // Quantos elementos a matriz tem no total

            Console.WriteLine(mat.Rank); // Quantidade de linhas
            Console.WriteLine(mat.GetLength(0)); // Imprime a primeira dimensao, neste caso 2
            Console.WriteLine(mat.GetLength(1)); // Imprime a segunda dimensao, neste caso, 3

            Console.WriteLine("------------------");

            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{matriz[i, i]} ");
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"\nNegative numbers: {count}");
        }
    }
}
