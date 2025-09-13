namespace BCC_MAAD.API.DTOs.Auth
{
    public class RegisterRequest
    {
        public int ClientCode { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
    }

}
