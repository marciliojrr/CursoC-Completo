using System;
using System.Globalization;

namespace ExercicioDeFixacao.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{DueDate:dd/MM/yyyy} - ${Amount.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
