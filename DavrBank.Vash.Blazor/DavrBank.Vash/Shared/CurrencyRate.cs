using System.Collections.Generic;
using DavrBank.Vash.Shared.Abstracts;

namespace DavrBank.Vash.Shared
{
    public class CurrencyRate : EntityBase
    {
        public double Rate { get; set; }

        public int CurrencyId { get; set; }

        public virtual Currency Currency { get; set; }

        //TODO: Date of rate need? or keep only valid 
    }
}
