using System;
using System.IO;

namespace StreamWriter1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Cursos\C# COMPLETO Programação Orientada a Objetos + Projetos - Udemy\Seção 13 - Trabalhando com arquivos\file1.txt";
            string targetPath = @"D:\Cursos\C# COMPLETO Programação Orientada a Objetos + Projetos - Udemy\Seção 13 - Trabalhando com arquivos\file2.txt";

            //Criando um novo arquivo (file2.txt) com o contudo de 'file1.txt', mas modificando tudo para maiusculo

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
