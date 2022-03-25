using System;
using System.IO;

namespace FileStreamAndStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1a maneira de fazer a leitura
            /*
            string path = @"D:\Cursos\C# COMPLETO Programação Orientada a Objetos + Projetos - Udemy\Seção 13 - Trabalhando com arquivos\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open); // FileStream e StreamReader sao recursos externos
                sr = new StreamReader(fs);                // Por isso temos que fechar esses recursos manualmente.

                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(e.Message);
            }
            finally // Sera executado independente de acontecer uma excecao ou nao. 
            {
                if (sr != null) sr.Close(); // Fechando o recurso StreamReader
                if (fs != null) fs.Close(); // Fechando o recurso FileStream
            }
            */
            // 2a maneira de fazer a leitura

            string path = @"D:\Cursos\C# COMPLETO Programação Orientada a Objetos + Projetos - Udemy\Seção 13 - Trabalhando com arquivos\file1.txt";
            StreamReader sr = null;
            StreamReader sr1 = null; // Nova declaracao, pois com um so, o while so leria a partir da linha que ja foi lida antes

            try
            {
                sr = File.OpenText(path);
                sr1 = File.OpenText(path);

                Console.WriteLine("Lendo uma linha:");
                string line = sr.ReadLine(); // Lendo uma linha somente
                Console.WriteLine(line);

                Console.WriteLine("Lendo todas as linhas:");
                while (!sr1.EndOfStream) // Lendo todas as linhas
                {
                    string line1 = sr1.ReadLine();
                    Console.WriteLine(line1);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(e.Message);
            }
            finally // Sera executado independente de acontecer uma excecao ou nao. 
            {
                if (sr != null) sr.Close(); // Fechando o recurso StreamReader
            }
        }
    }
}
