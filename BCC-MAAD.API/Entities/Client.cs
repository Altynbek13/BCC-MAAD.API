namespace BCC_MAAD.API.Entities
{
    public class Client
    {
        public int Id { get; set; }    
        public int ClientCode { get; set; }       
        public string Name { get; set; }
        public string Status { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public decimal AvgMonthlyBalanceKzt { get; set; }

        public string Password { get; set; }

        public decimal Balance { get; set; }

        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public ICollection<Transfer> Transfers { get; set; } = new List<Transfer>();
    }
}
