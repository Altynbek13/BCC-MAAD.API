using BCC_MAAD.API.DTOs;

namespace BCC_MAAD.API.Services
{
    public interface ITransferService
    {
        Task<List<TransferDto>> GetTransfersAsync(int clientCode);
        Task AddTransferAsync(int clientCode, TransferDto dto);
    }
}
