using System;
using System.IO;

namespace FileAndFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // O uso do '@' abaixo serve para que nao seja necessario usar duas barras no caminho do arquivo
            string sourcePath = @"D:\Cursos\C# COMPLETO Programação Orientada a Objetos + Projetos - Udemy\Seção 13 - Trabalhando com arquivos\file1.txt";
            string targetPath = @"D:\Cursos\C# COMPLETO Programação Orientada a Objetos + Projetos - Udemy\Seção 13 - Trabalhando com arquivos\file2.txt";

            try
            {
                // Copiando arquivos
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                // Lendo um arquivo e exibindo seu conteudo na tela
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred,");
                Console.WriteLine(e.Message);
            }
        }
    }
}
