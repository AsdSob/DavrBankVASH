using AutoMapper;
using VASHApi.DTOs;
using VASHApi.Entities;

namespace VASHApi.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Currency, CurrencyDto>();
            CreateMap<CurrencyRate, CurrencyRateDto>();
            CreateMap<Citizen, CitizenDto>();
            CreateMap<DocumentType, DocumentTypeDto>();

        }
    }
}
