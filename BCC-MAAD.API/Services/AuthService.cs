using BCC_MAAD.API.DTOs.Auth;
using BCC_MAAD.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BCC_MAAD.API.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;
        private readonly IJwtService _jwtService;

        public AuthService(AppDbContext context, IJwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        public async Task<RegisterResponse> RegisterAsync(RegisterRequest request)
        {
            if (await _context.Clients.AnyAsync(c => c.ClientCode == request.ClientCode))
            {
                throw new Exception($"ClientCode {request.ClientCode} уже существует. Выберите другой.");
            }
            var client = new Client
            {
                Name = request.Name,
                Status = request.Status,
                City = request.City,
                Password = request.Password,
                ClientCode = request.ClientCode
            };

            _context.Clients.Add(client);
            await _context.SaveChangesAsync();

            return new RegisterResponse
            {
                ClientCode = client.ClientCode,
                Name = client.Name
            };
        }

        public async Task<LoginResponse> LoginAsync(LoginRequest request)
        {
            var client = await _context.Clients
                .FirstOrDefaultAsync(c => c.ClientCode == request.ClientCode && c.Password == request.Password);

            if (client == null)
                throw new UnauthorizedAccessException("Неверный client_code или пароль");

            var token = _jwtService.GenerateToken(client);

            return new LoginResponse { Token = token };
        }

        public async Task<MeResponse> GetCurrentUserAsync(ClaimsPrincipal user)
        {
            var clientCode = user.FindFirst("client_code").Value;
            var client = await _context.Clients.FirstAsync(c => c.ClientCode == clientCode);

            return new MeResponse
            {
                ClientCode = client.ClientCode,
                Name = client.Name,
                Age = client.Age,
                Status = client.Status,
                City = client.City,
                AvgMonthlyBalanceKzt = client.AvgMonthlyBalanceKzt
            };
        }
    }

}
