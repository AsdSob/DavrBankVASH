using System.Collections;
using System.Collections.Generic;
using VASHApi.Entities.Abstracts;

namespace VASHApi.Entities
{
    public class CurrencyRate : EntityBase
    {
        public double Rate { get; set; }

        public int CurrencyId { get; set; }

        public virtual Currency Currency { get; set; }
        public ICollection<ExchangeTransaction> ExchangeTransactions { get; set; }

        //TODO: Date of rate need? or keep only valid 
    }
}
