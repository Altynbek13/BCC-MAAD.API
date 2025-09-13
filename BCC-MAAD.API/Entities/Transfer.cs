namespace BCC_MAAD.API.Entities
{
    public class Transfer
    {
        public int Id { get; set; }                
        public DateTime Date { get; set; }

        public string Type { get; set; }    
        public string Direction { get; set; }

        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public int ClientCode { get; set; }
        public Client Client { get; set; }
    }
}
