using System;

namespace exercicio_classes
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return (2 * Largura) + (2 * Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2.0) + Math.Pow(Largura, 2.0));
        }
    }
}
