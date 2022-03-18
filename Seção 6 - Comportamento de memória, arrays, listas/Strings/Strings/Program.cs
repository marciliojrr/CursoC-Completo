using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            // Converter todos para maiusculo
            string s1 = original.ToUpper();
            Console.WriteLine($"Original: |{original}|");
            Console.WriteLine($"ToUpper(): |{s1}|\n");

            // Converter todos para minusculo
            string s2 = original.ToLower();
            Console.WriteLine($"Original: |{original}|");
            Console.WriteLine($"ToLower(): |{s2}|\n");

            // Apaga espacos em branco na frente e no final da string
            string s3 = original.Trim();
            Console.WriteLine($"Original: |{original}|");
            Console.WriteLine($"ToLower(): |{s3}|\n");

            // Encontrar a posicao da primeira ocorrencia do "bc" na string
            int n1 = original.IndexOf("bc");
            Console.WriteLine($"IndexOf ('bc'): |{n1}|\n");

            // Encontrar a posicao da ultima ocorrencia do "bc" na string
            int n2 = original.LastIndexOf("bc");
            Console.WriteLine($"LastIndexOf ('bc'): |{n2}|\n");

            // Recortar uma string
            string s4 = original.Substring(3);
            Console.WriteLine($"Substring(3): |{s4}|\n");

            string s5 = original.Substring(3, 5); // 5 caracteres a partir da posicao 3
            Console.WriteLine($"Substring(3, 5): |{s5}|\n");

            // Substituir uma parte de uma string
            string s6 = original.Replace('a', 'x'); // 5 caracteres a partir da posicao 3
            Console.WriteLine($"Replace('a', 'x'): |{s6}|\n");

            string s7 = original.Replace("abc", "xy"); // 5 caracteres a partir da posicao 3
            Console.WriteLine($"Replace('abc', 'xy'): |{s7}|\n");

            // Testar de string e' vazia
            bool b1 = String.IsNullOrEmpty(original);
            Console.WriteLine($"IsNullOrEmpt: {b1}");

            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine($"IsNullOrWhiteSpace: {b2}");
        }
    }
}
