using BCC_MAAD.API.DTOs;
using BCC_MAAD.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace BCC_MAAD.API.Controllers
{
    [ApiController]
    [Route("clientAnalyze")]
    [Authorize]
    public class ClientAnalyzeController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;


        public ClientAnalyzeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpPost("analyze")]
        public async Task<IActionResult> AnalyzeClient()
        {
            var clientCodeStr = User.FindFirst("client_code").Value;
            if (!int.TryParse(clientCodeStr, out var clientCode))
                return BadRequest("Некорректный client_code");

            var httpClient = _httpClientFactory.CreateClient();
            var url = $"http://188.244.115.175:7778/api/v1/test/client/{clientCode}";
            var response = await httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return NotFound("Внешний API не найден или недоступен. Проверьте правильность URL.");

            var responseBody = await response.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(responseBody);
            var recommendations = doc.RootElement.GetProperty("recommendations");
            if (recommendations.GetArrayLength() == 0)
                return NotFound("Рекомендации не найдены.");

            var pushNotification = recommendations[0].GetProperty("push_notification").GetString();
            return Ok(pushNotification);
        }
    }
}