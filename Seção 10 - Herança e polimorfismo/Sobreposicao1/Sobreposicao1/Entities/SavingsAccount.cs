namespace Sobreposicao1.Entities
{
    internal class SavingsAccount : Account // "sealed" impede que subclasses seja criadas a partir de SavingsAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double ballance, double interestRate) : base(number, holder, ballance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Ballance += Ballance * InterestRate;
        }

        public sealed override void WithDraw(double amount) // "override" sobrescreve um metodo da superclasse
        // "sealed" nao pode ser sobrescrita novamente
        {
            base.WithDraw(amount); // "base" utiliza a regra padrao da superclasse
            Ballance -= 2.0;
        }
    }
}
