using ExercicioFixacao.Entities;
using System;
using System.Globalization;
using System.IO;

namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lendo caminho do arquivo de onde sera extraido os dados (cart.csv)
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                // Salvando em lista o caminho do arquivo cart.csv
                string[] lines = File.ReadAllLines(sourceFilePath);

                // Obtendo apenas o diretorio de onde esta o arquivo
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);

                // Definindo diretorio de saida do arquivo
                string targetFolderPath = sourceFolderPath + @"\out";

                // Definindo caminho completo do arquivo de saida
                string targetFilePath = targetFolderPath + @"\summary.csv";

                // Criando o diretorio de saida
                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = new StreamWriter(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');

                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quanity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quanity);

                        sw.WriteLine($"{prod.Name},{prod.Total().ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
