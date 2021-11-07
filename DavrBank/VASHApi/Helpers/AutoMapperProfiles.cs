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
            CreateMap<CurrencyDto, Currency>();

            CreateMap<CurrencyRate, CurrencyRateDto>();
            CreateMap<CurrencyRateDto, CurrencyRate>();

            CreateMap<Citizen, CitizenDto>();
            CreateMap<DocumentType, DocumentTypeDto>();

        }
    }
}
