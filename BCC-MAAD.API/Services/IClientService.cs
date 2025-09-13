using BCC_MAAD.API.DTOs;

namespace BCC_MAAD.API.Services
{
    public interface IClientService
    {
        Task<ClientProfileDto> GetProfileAsync(int clientCode);
        Task<decimal> GetBalanceAsync(int clientCode);
    }
}
