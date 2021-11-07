using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using DavrBank.Vash.Shared;

namespace DavrBank.Vash.Client.Services
{
    public class CurrencyService :ICurrencyService
    {
        public List<Currency> Currencies { get; set; } = new List<Currency>();

        private readonly HttpClient _httpClient;

        public CurrencyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Currency>> GetCurrencies()
        {
            Currencies = await _httpClient.GetFromJsonAsync<List<Currency>>("/currency");

            return Currencies;
        }
    }
}
