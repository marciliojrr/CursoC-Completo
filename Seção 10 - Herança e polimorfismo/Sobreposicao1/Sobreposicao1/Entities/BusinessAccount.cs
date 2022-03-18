namespace Sobreposicao1.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double ballance, double loanLimit) : base(number, holder, ballance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Ballance += amount;
            }
        }
    }
}
