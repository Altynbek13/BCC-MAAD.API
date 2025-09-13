namespace BCC_MAAD.API.DTOs.Auth
{
    public class MeResponse
    {
        public string ClientCode { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public decimal AvgMonthlyBalanceKzt { get; set; }
    }
}
