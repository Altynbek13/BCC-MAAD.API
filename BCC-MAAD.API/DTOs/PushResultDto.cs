namespace BCC_MAAD.API.DTOs
{
    public class PushResultDto
    {
        public int ClientCode { get; set; }
        public string Product { get; set; } 
        public string PushNotification { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
