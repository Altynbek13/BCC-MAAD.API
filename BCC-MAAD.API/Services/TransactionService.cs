using BCC_MAAD.API.DTOs;
using BCC_MAAD.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BCC_MAAD.API.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly AppDbContext _context;

        public TransactionService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TransactionDto>> GetTransactionsAsync(int clientCode)
        {
            return await _context.Transactions
                .AsNoTracking()
                .Where(t => t.ClientCode == clientCode)
                .OrderByDescending(t => t.Date)
                .Select(t => new TransactionDto
                {
                    Id = t.Id,
                    Date = t.Date,
                    Category = t.Category,
                    Amount = t.Amount,
                    Currency = t.Currency
                })
                .ToListAsync();
        }

        public async Task AddTransactionAsync(int clientCode, TransactionDto dto)
        {
            var transaction = new Transaction
            {
                ClientCode = clientCode,
                Date = dto.Date != default ? dto.Date : DateTime.UtcNow,
                Category = dto.Category,
                Amount = dto.Amount,
                Currency = dto.Currency
            };

            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();
        }
    }
}

