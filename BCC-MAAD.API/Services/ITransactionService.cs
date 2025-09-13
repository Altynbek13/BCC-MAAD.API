using BCC_MAAD.API.DTOs;

namespace BCC_MAAD.API.Services
{
    public interface ITransactionService
    {
        Task<List<TransactionDto>> GetTransactionsAsync(string clientCode);
        Task AddTransactionAsync(string clientCode, TransactionDto dto);
    }
}
