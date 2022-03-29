using System;
using System.IO;
using System.Collections.Generic;


namespace ExercicioPropostoDict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Dictionary<string, int> dict = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] lines = sr.ReadLine().Split(',');
                        string candidate = lines[0];
                        int votes = int.Parse(lines[1]);

                        if (dict.ContainsKey(candidate))
                        {
                            dict[candidate] += votes;
                        }
                        else
                        {
                            dict[candidate] = votes;
                        }
                    }

                    foreach (KeyValuePair<string, int> line in dict)
                    {
                        Console.WriteLine($"{line.Key}: {line.Value}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
