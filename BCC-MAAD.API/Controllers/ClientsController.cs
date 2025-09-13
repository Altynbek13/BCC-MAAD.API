using BCC_MAAD.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BCC_MAAD.API.Controllers
{
    [ApiController]
    [Route("client")]
    [Authorize]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("profile")]
        public async Task<IActionResult> GetProfile()
        {
            var clientCode = User.FindFirst("client_code").Value;
            var profile = await _clientService.GetProfileAsync(clientCode);
            return Ok(profile);
        }

        [HttpGet("balance")]
        public async Task<IActionResult> GetBalance()
        {
            var clientCode = User.FindFirst("client_code").Value;
            var balance = await _clientService.GetBalanceAsync(clientCode);
            return Ok(balance);
        }
    }
}
