namespace BusTicketSystem.Models
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }

        public string AccountNumbet { get; set; }

        public decimal Balance { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
