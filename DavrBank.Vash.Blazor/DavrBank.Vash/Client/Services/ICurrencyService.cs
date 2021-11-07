using System.Collections.Generic;
using System.Threading.Tasks;
using DavrBank.Vash.Shared;

namespace DavrBank.Vash.Client.Services
{
    public interface ICurrencyService
    {
        List<Currency> Currencies { get; set; }
        Task<List<Currency>> GetCurrencies();
    }
}
