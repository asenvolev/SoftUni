namespace P01_BillsPaymentSystem.Data.Models
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }

        public decimal Balance { get; private set; }

        public string BankName { get; set; }

        public string SWIFTCode { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public decimal Withdraw(decimal sum)
        {
            return this.Balance -= sum;
        }

        public decimal Deposit(decimal sum)
        {
            return this.Balance += sum;
        }
    }
}
