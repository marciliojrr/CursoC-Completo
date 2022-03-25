namespace ExercicioComInterface.Services
{
    internal class BrazilTaxService : ITaxService // Declarando que e' um subtipo 
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
