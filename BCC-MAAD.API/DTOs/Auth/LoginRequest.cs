namespace BCC_MAAD.API.DTOs.Auth
{
    public class LoginRequest
    {
        public int ClientCode { get; set; }
        public string Password { get; set; }
    }
}
