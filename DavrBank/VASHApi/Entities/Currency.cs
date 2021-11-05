using System.Collections.Generic;
using VASHApi.Entities.Abstracts;

namespace VASHApi.Entities
{
    public class Currency : EntityBase
    {
        public string Name { get; set; }

        public ICollection<CurrencyRate> CurrencyRates { get; set; }
    }
}
