using ExercicioPropostoFinal.Entities;
using System.Globalization;

namespace ExercicioPropostoFinal.Entities
{
    internal class Company : TaxPayer
    {
        // AutoProps
        public int Employees { get; set; }

        // Constructors
        public Company(string name, double anualIncome, int numEmployees) : base(name, anualIncome)
        {
            Employees = numEmployees;
        }

        // Methods
        public override double Taxes()
        {
            if (Employees > 10)
            {
                return AnualIncome * 0.14;
            }
            else 
            {
                return AnualIncome * 0.16;
            }
        }

        public override string ShowTaxes()
        {
            return $"{Name}: ${Taxes().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
