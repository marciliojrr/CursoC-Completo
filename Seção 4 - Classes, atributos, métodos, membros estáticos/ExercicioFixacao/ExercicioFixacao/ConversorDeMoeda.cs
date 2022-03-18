namespace ExercicioFixacao
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;
        public static double ConverteDolar(double dolar, double qtdEmReais)
        {
            double valorParcial = dolar * qtdEmReais;
            return valorParcial += (dolar * qtdEmReais) * Iof;
        }
    }
}
