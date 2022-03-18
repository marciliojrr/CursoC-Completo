using System;
using System.Globalization;

namespace Course
{
    internal class EntradaDeDados1
    {
        static void Main(string[] args)
        {
            /*
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            //  Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);

            // Interpolacao
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");

            // Concatenacao
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");

            Console.WriteLine("----");
            Console.WriteLine(saldo.ToString("F2")); // Duas casas decimais
            Console.WriteLine(saldo.ToString("F4")); // Quatro casas decimais

            // Usar separador '.' ao inves de ','
            // Precisa incluir o namespace System.Globalization
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); 

            */

            /*
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string s = Console.ReadLine();

            string[] vet = s.Split(' ');

            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(s);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            string[] v = Console.ReadLine().Split(' ');
            Console.WriteLine("v: " + v);
            */

            /*
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet =  Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */

            // Exercicio 1 - estrutura seq.
            /*
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preco de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade, altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */

            // Estrutura condicional
            /*
            Console.WriteLine("Entre com um numero inteiro:");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("PAR!");
            }
            else
            {
                Console.WriteLine("IMPAR!");
            }

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (hora >= 12 && hora < 18) // else if (hora < 18) {}
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
            */

            // Funcoes
            Console.WriteLine("Digite tres numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            // Codigo para achar o maior dentre tres numeros
            /*if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"Maior = {n1}");
            }
            else if (n2 > n3)
            {
                Console.WriteLine($"Maior = {n2}");
            }
            else
            {
                Console.WriteLine($"Maior = {n3}");
            }
            }*/

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine($"Maior = {resultado}");
        } // esta chave fecha a static void Main

        // Criando uma funcao para achar o maior dentre tres numeros
        // static [tipo de saida da funcao] [nome da funcao] (parametros de entrada)
        static int Maior(int a, int b, int c)
        {
        int m;

        if (a > b && a > c)
        {
            m = a;
        }
        else if (b > c)
        {
            m = b;
        }
        else
        {
            m = c;
        }
        return m;
        }
		// F9 adiciona um breakpoint. F5 inicia a execucao passo-a-passo. F10 executa um passo (pulando funcoes)
            // F11 executa um passo (entrando nas funcoes)

    }
}
