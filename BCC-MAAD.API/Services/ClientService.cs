using BCC_MAAD.API.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BCC_MAAD.API.Services
{
    public class ClientService : IClientService
    {
        private readonly AppDbContext _context;

        public ClientService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ClientProfileDto> GetProfileAsync(string clientCode)
        {
            var client = await _context.Clients
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.ClientCode == clientCode);

            if (client == null)
                throw new Exception("Клиент не найден");

            return new ClientProfileDto
            {
                ClientCode = client.ClientCode,
                Name = client.Name,
                Age = client.Age,
                Status = client.Status,
                City = client.City,
                AvgMonthlyBalanceKzt = client.AvgMonthlyBalanceKzt
            };
        }

        public async Task<decimal> GetBalanceAsync(string clientCode)
        {
            var client = await _context.Clients
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.ClientCode == clientCode);

            if (client == null)
                throw new Exception("Клиент не найден");

            return client.AvgMonthlyBalanceKzt;
        }
    }
}
