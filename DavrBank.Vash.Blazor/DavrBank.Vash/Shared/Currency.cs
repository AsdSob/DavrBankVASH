using System.Collections.Generic;
using DavrBank.Vash.Shared.Abstracts;

namespace DavrBank.Vash.Shared
{
    public class Currency : EntityBase
    {
        public string Name { get; set; }

        public ICollection<CurrencyRate> CurrencyRates { get; set; }
    }
}
