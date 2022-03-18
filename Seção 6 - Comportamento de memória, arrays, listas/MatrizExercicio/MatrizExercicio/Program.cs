using System;

namespace MatrizExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definindo tamanho da matriz
            string[] dim = Console.ReadLine().Split(' ');
            int m = int.Parse(dim[0]);
            int n = int.Parse(dim[1]);

            int[,] matrix = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] aux = Console.ReadLine().Split(' '); // Le uma linha de numeros separados por ' '
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(aux[j]);
                }
            }

            int searchNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == searchNumber)
                    {
                        Console.WriteLine($"Position {i}, {j}:");
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {matrix[i, j - 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {matrix[i - 1, j]}");
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine($"Right: {matrix[i, j + 1]}");
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine($"Down: {matrix[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}