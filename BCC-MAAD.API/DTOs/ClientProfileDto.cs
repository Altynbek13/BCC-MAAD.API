namespace BCC_MAAD.API.DTOs
{
    public class ClientProfileDto
    {
        public string ClientCode { get; set; }
        public string Name { get; set; } 
        public int Age { get; set; }
        public string Status { get; set; } 
        public string City { get; set; }
        public decimal AvgMonthlyBalanceKzt { get; set; }
    }
}
