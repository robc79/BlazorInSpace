using WhosInSpace.Models;

namespace WhosInSpace.Services
{
    public class HttpAstrosService : IAstrosService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _httpClient;
        private AstrosData _cachedData = null;

        public HttpAstrosService(IHttpClientFactory factory)
        {
            _httpClientFactory = factory ?? throw new ArgumentNullException(nameof(factory));
            _httpClient = _httpClientFactory.CreateClient("Astros");
        }

        public async Task<AstrosData?> GetAstrosAsync()
        {
            if (_cachedData == null)
            {
                _cachedData = await _httpClient.GetFromJsonAsync<AstrosData>("astros.json");
            }

            return _cachedData;
        }
    }
}
