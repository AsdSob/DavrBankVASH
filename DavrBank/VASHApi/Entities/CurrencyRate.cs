using VASHApi.Entities.Abstracts;

namespace VASHApi.Entities
{
    public class CurrencyRate : EntityBase
    {
        public double Rate { get; set; }

        public int CurrencyId { get; set; }

        public virtual Currency Currency { get; set; }

        //TODO: Date of rate need? or keep only valid 
    }
}
