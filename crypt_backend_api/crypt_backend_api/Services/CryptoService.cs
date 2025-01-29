using crypt_backend_api.Classes;
using crypt_backend_api.Utilities;

namespace crypt_backend_api.Services
{
    public class CryptoService
    {
        private readonly HttpClient _httpClient;

        public CryptoService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri(configuration["API_Server"]);
        }

        public async Task<List<CryptoModel>> GetCryptos()
        {
            HttpResponseMessage response =  await _httpClient.GetAsync("posts/1");

            if(response.IsSuccessStatusCode)
            {
                return TestingLibrary.GetTestingCryptoModelList();
            }
            else
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }
    }
}
