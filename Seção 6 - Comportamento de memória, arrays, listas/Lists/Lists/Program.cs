using System;
using System.Collections.Generic; // Para usar List

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); // Cria uma lista vazia
            List<string> list2 = new List<string> { "Maria", "Alex", "Bob", "Anna" }; // Cria uma lista e instancia com elementos

            Console.WriteLine(list);
            Console.WriteLine(list2);

            // Operacoes //

            // Adicionar

            // - Add: insere no final da lista
            List<string> list3 = new List<string>();
            list3.Add("Maria");
            list3.Add("Alex");
            list3.Add("Bob");
            list3.Add("Anna");

            foreach (string obj in list3)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------------");
            // - Insert: pode informar a posicao para insercao
            list3.Insert(2, "Marco");

            foreach (string obj in list3)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------");

            // Tamanho da lista
            Console.WriteLine($"List count: {list3.Count}");
            Console.WriteLine("-----------------------------");

            // Encontrar primeiro ou ultimo elemento (ocorrencia) da lista que satisfaca um predicado
            string s1 = list3.Find(x => x[0] == 'A'); // Usando uma funcao anonima (lambda)
            Console.WriteLine($"First 'A': {s1}");

            string s2 = list3.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Last'A': {s2}");
            Console.WriteLine("-----------------------------");

            // Encontrar primeiro ou ultima POSICAO do elemento da lista que satisfaca um predicado
            int pos1 = list3.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First position 'A': {pos1}");

            int pos2 = list3.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Last position 'A': {pos2}");
            Console.WriteLine("-----------------------------");

            // Filtrar lista com base em um predicado
            List<string> list4 = list3.FindAll(x => x.Length == 5);

            foreach (string obj in list4)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------");

            // Remover um item da lista

            // - Remove
            list3.Remove("Alex");
            foreach (string obj in list3)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------");

            // - RemoveAll
            list3.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list3)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------");

            // - RemoveAt (remover na posicao)
            list3.RemoveAt(1);
            foreach (string obj in list3)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------");

            // - RemoveRange (remover uma faixa de posicoes)
            list2.RemoveRange(2, 2);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
