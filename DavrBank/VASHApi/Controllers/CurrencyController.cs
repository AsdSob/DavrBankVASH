using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VASHApi.DataAccess;
using VASHApi.DTOs;
using VASHApi.Entities;
using VASHApi.Helpers;
using VASHApi.Services;

namespace VASHApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        protected readonly IPageResponseService _pageResponseService;
        protected readonly DataContext _dbContext;

        public CurrencyController(IPageResponseService pageService, DataContext dbContext)
        {
            _pageResponseService = pageService;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Currency> GetAll()
        {
            //Get entities filtered with expression
            var models = _dbContext.Currencies;

            //Set page response
            var pageResponse = _pageResponseService.GetPageResponse<Currency, CurrencyDto>(models);

            return Ok(pageResponse);
        }


        [HttpGet]
        public IEnumerable<Currency> Get()
        {
            //Convert filter array to expression
            var exp = requestFilter.Filters.FiltersToExpression<TModel>();

            //Get entities filtered with expression
            var models = await _dbContext.GetEntities(exp);

            //Set page response
            var pageResponse = _pageResponseService.GetPageResponse<TModel, TDto>(models, requestFilter);

            return Ok(pageResponse);
        }

    }
}
