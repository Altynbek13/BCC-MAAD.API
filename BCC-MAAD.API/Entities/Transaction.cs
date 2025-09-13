namespace BCC_MAAD.API.Entities
{
    public class Transaction
    {
        public int Id { get; set; }           
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public int ClientCode { get; set; }
        public Client Client { get; set; }
    }
}
