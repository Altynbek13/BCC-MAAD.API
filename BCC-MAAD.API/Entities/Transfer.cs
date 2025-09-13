using System.ComponentModel.DataAnnotations.Schema;

namespace BCC_MAAD.API.Entities
{
    public class Transfer
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("direction")]
        public string Direction { get; set; }
        [Column("amount")]
        public decimal Amount { get; set; }
        [Column("currency")]
        public string Currency { get; set; }
        [Column("client_code")]
        public string ClientCode { get; set; }
        public Client Client { get; set; }
    }
}
