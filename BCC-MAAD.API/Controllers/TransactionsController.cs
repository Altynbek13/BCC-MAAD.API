using BCC_MAAD.API.DTOs;
using BCC_MAAD.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BCC_MAAD.API.Controllers
{
    [ApiController]
    [Route("transactions")]
    [Authorize]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTransactions()
        {
            var clientCode = int.Parse(User.FindFirst("client_code").Value);
            var txs = await _transactionService.GetTransactionsAsync(clientCode);
            return Ok(txs);
        }

        [HttpPost]
        public async Task<IActionResult> AddTransaction([FromForm] TransactionDto dto)
        {
            var clientCode = int.Parse(User.FindFirst("client_code").Value);
            await _transactionService.AddTransactionAsync(clientCode, dto);
            return Ok(new { message = "Transaction added" });
        }
    }
}
