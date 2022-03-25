using System;
using System.IO;

namespace UsingBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Cursos\C# COMPLETO Programação Orientada a Objetos + Projetos - Udemy\Seção 13 - Trabalhando com arquivos\file1.txt";
            // MODO 1

            try
            {
                /* 
                 * 'using' permite que os recursos que deveriam ser fechados
                 * manualmente, fechem sozinhos, evitando ter que usar metodos
                 * como o 'finally' para fecha-los.
                 */

                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }

            // MODO 2

            try
            {
                using (StreamReader sr1 = File.OpenText(path))
                {
                    while (!sr1.EndOfStream)
                    {
                        string line = sr1.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
