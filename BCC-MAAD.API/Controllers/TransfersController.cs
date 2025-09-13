using BCC_MAAD.API.DTOs;
using BCC_MAAD.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BCC_MAAD.API.Controllers
{
    [ApiController]
    [Route("transfers")]
    [Authorize]
    public class TransfersController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransfersController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTransfers()
        {
            var clientCode = int.Parse(User.FindFirst("client_code").Value);
            var transfers = await _transferService.GetTransfersAsync(clientCode);
            return Ok(transfers);
        }

        [HttpPost]
        public async Task<IActionResult> AddTransfer([FromForm] TransferDto dto)
        {
            var clientCode = int.Parse(User.FindFirst("client_code").Value);
            await _transferService.AddTransferAsync(clientCode, dto);
            return Ok(new { message = "Transfer added" });
        }
    }
}
