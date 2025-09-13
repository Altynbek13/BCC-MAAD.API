using BCC_MAAD.API.DTOs;
using BCC_MAAD.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BCC_MAAD.API.Services
{
    public class TransferService : ITransferService
    {
        private readonly AppDbContext _context;

        public TransferService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TransferDto>> GetTransfersAsync(string clientCode)
        {
            return await _context.Transfers
                .AsNoTracking()
                .Where(t => t.ClientCode == clientCode)
                .OrderByDescending(t => t.Date)
                .Select(t => new TransferDto
                {
                    Id = t.Id,
                    Date = t.Date,
                    Type = t.Type,
                    Direction = t.Direction,
                    Amount = t.Amount,
                    Currency = t.Currency
                })
                .ToListAsync();
        }

        public async Task AddTransferAsync(string clientCode, TransferDto dto)
        {
            var transfer = new Transfer
            {
                ClientCode = clientCode,
                Date = dto.Date != default ? dto.Date : DateTime.UtcNow,
                Type = dto.Type,
                Direction = dto.Direction,
                Amount = dto.Amount,
                Currency = dto.Currency
            };

            _context.Transfers.Add(transfer);
            await _context.SaveChangesAsync();
        }
    }
}
