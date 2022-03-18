using System.Globalization;

namespace exercicio_classes
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);
        }

        public override string ToString()
        {
            return $"Funcionario: {Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
