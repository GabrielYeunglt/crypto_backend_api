using crypt_backend_api.Classes;
using crypt_backend_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace crypt_backend_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CryptoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CryptoController> _logger;
        private readonly CryptoService _cryptoService;

        public CryptoController(ILogger<CryptoController> logger, CryptoService cryptoService)
        {
            _logger = logger;
            _cryptoService = cryptoService;
        }

        [HttpGet(Name = "GetCryptoList")]
        public async Task<List<CryptoModel>> Get()
        {
            List<CryptoModel> result = await _cryptoService.GetCryptos();
            return result;
        }
    }
}
