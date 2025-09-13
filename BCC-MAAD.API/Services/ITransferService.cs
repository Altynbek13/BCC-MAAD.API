using BCC_MAAD.API.DTOs;

namespace BCC_MAAD.API.Services
{
    public interface ITransferService
    {
        Task<List<TransferDto>> GetTransfersAsync(string clientCode);
        Task AddTransferAsync(string clientCode, TransferDto dto);
    }
}
