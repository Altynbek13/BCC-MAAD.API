using System.ComponentModel.DataAnnotations.Schema;

namespace BCC_MAAD.API.Entities
{
    public class Client
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("client_code")]
        public string ClientCode { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("status")]
        public string Status { get; set; }
        [Column("age")]
        public int? Age { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("avg_monthly_balance_kzt")]
        public decimal AvgMonthlyBalanceKzt { get; set; }
        [Column("password")]
        public string Password { get; set; }

        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public ICollection<Transfer> Transfers { get; set; } = new List<Transfer>();
    }
}
