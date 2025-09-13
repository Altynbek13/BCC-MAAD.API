using System.ComponentModel.DataAnnotations.Schema;

namespace BCC_MAAD.API.Entities
{
    public class Transaction
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("category")]
        public string Category { get; set; }
        [Column("amount")]
        public decimal Amount { get; set; }
        [Column("currency")]
        public string Currency { get; set; }
        [Column("client_code")]
        public string ClientCode { get; set; }
        public Client Client { get; set; }
    }
}
