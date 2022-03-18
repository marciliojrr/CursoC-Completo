using System;
using System.Globalization;

namespace exercicio_classes
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3, SomaNotas;
        public double NotaMinima = 60.00;

        public string NotaFinal()
        {
            SomaNotas = Nota1 + Nota2 + Nota3;
            return $"{SomaNotas.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public string ResultadoFinal()
        {
            if (SomaNotas >= NotaMinima)
            {
                return $"APROVADO";
            }
            else
            {
                Console.WriteLine("REPROVADO");
                return $"FALTARAM {(NotaMinima - SomaNotas).ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
            }
        }
    }
}
