namespace Example2.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double ballance, double interestRate) : base(number, holder, ballance)
        {
            InterestRate =  interestRate;
        }

        public void UpdateBalance()
        {
            Ballance += Ballance * InterestRate;
        }
    }
}
