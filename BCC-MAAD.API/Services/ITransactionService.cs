using BCC_MAAD.API.DTOs;

namespace BCC_MAAD.API.Services
{
    public interface ITransactionService
    {
        Task<List<TransactionDto>> GetTransactionsAsync(int clientCode);
        Task AddTransactionAsync(int clientCode, TransactionDto dto);
    }
}
