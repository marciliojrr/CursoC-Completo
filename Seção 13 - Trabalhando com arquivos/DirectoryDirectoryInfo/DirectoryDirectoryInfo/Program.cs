using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Cursos\C# COMPLETO Programação Orientada a Objetos + Projetos - Udemy\Seção 13 - Trabalhando com arquivos\myfolder";

            try
            {
                // Listar todas as subpastas a partir de 'myfolder'
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                
                // Podemos usar tambem 'var' para que o C# faca a inferencia de tipos
                // var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                Console.WriteLine("-------");
                
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                // Listar todos os arquivos a partir de uma pasta informada
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FILES: ");
                Console.WriteLine("-----");

                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                // Criando uma pasta 'newfolder' a partir da pasta 'myfolder'
                Directory.CreateDirectory(path + "\\newfolder");
                Directory.CreateDirectory(path + @"\newfolder2");
                Directory.CreateDirectory(@"D:\Cursos\C# COMPLETO Programação Orientada a Objetos + Projetos - Udemy\Seção 13 - Trabalhando com arquivos\myfolder\newfolder3");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurried!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
