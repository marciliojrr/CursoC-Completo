namespace ExercicioPropostoFinal.Entities
{
    internal abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        // Constructors
        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        // Methods
        public abstract double Taxes();
        public abstract string ShowTaxes();
    }
}
