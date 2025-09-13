using BCC_MAAD.API.DTOs.Auth;
using System.Security.Claims;

namespace BCC_MAAD.API.Services
{
    public interface IAuthService
    {
        Task<RegisterResponse> RegisterAsync(RegisterRequest request);
        Task<LoginResponse> LoginAsync(LoginRequest request);
        Task<MeResponse> GetCurrentUserAsync(ClaimsPrincipal user);
    }
}
