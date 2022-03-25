using System.Globalization;

namespace ExercicioComInterface.Entities
{
    internal class Invoice
    {
        // AutoProp
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        // Constructor
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        // Propriedade calculada
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basic payment: ${BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Tax: ${Tax.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Total payment: ${TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
