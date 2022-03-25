using System;
using System.IO;

namespace PATH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Cursos\C# COMPLETO Programação Orientada a Objetos + Projetos - Udemy\Seção 13 - Trabalhando com arquivos\myfolder\file1.txt";

            Console.WriteLine($"- DirectorySeparatorChar: {Path.DirectorySeparatorChar}\n");
            Console.WriteLine($"- PathSeparator: {Path.PathSeparator}\n");
            Console.WriteLine($"- GetDirectoryName: {Path.GetDirectoryName(path)}\n");
            Console.WriteLine($"- GetFileName: {Path.GetFileName(path)}\n");
            Console.WriteLine($"- GetExtension: {Path.GetExtension(path)}\n");
            Console.WriteLine($"- GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(path)}\n");
            Console.WriteLine($"- GetFullPath: {Path.GetFullPath(path)}\n");
            Console.WriteLine($"- GetTempPath: {Path.GetTempPath()}\n");
        }
    }
}
