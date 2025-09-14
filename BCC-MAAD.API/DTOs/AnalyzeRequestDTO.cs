
namespace BCC_MAAD.API.DTOs
{
    public class AnalyzeRequestDTO
    {
        public string ClientCode { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public decimal AvgMonthlyBalanceKzt { get; set; }
        public string City { get; set; }
        public int? Age { get; set; }
        public List<TransactionDto>? Transactions { get; set; }
        public List<TransferDto>? Transfers { get; set; }
    }
}
