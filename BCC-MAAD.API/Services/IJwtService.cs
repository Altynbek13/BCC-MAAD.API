using BCC_MAAD.API.Entities;

namespace BCC_MAAD.API.Services
{
    public interface IJwtService
    {
        string GenerateToken(Client client);
    }
}
