using BCC_MAAD.API.DTOs;

namespace BCC_MAAD.API.Services
{
    public interface IClientService
    {
        Task<ClientProfileDto> GetProfileAsync(string clientCode);
        Task<decimal> GetBalanceAsync(string clientCode);
    }
}
