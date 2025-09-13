namespace BCC_MAAD.API.DTOs
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; } 
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
