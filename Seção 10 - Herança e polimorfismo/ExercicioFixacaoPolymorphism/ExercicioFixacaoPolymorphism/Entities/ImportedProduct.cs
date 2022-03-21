using System.Globalization;

namespace ExercicioFixacaoPolymorphism.Entities
{
    internal class ImportedProduct : Product
    {
        // AutoProps
        public double CustomsFee { get; protected set; }

        // Constructos
        public ImportedProduct() { } // Empty constructor

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        // Methods
        public double TotalPrice()
        {
            double total = Price + CustomsFee;
            return total;
        }

        public override string PriceTag()
        {
            return $"{Name} ${TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs Fee: ${CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
