using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
        protected readonly IMapper _mapper;

        public CurrencyController(IPageResponseService pageService, DataContext dbContext, IMapper mapper)
        {
            _pageResponseService = pageService;
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var models = _dbContext.Currencies;

            var dtos = _mapper.Map<IList<CurrencyDto>>(models).ToArray();

            var pageResponse = _pageResponseService.GetPageResponse<CurrencyDto>(dtos);

            return Ok(pageResponse);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromBody] int id)
        {
            var model = _dbContext.Currencies.Find(id);

            return Ok(model);
        }

        [HttpPost("{CurrencyDto}")]
        public virtual async Task<IActionResult> Add([FromBody] CurrencyDto tDto)
        {
            var model = _mapper.Map<Currency>(tDto);

            _dbContext.Currencies.Add(model);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpPost]
        public virtual async Task<IActionResult> AddRange([FromBody] IList<CurrencyDto> tDto)
        {
            var model = _mapper.Map<List<Currency>>(tDto);

            _dbContext.Currencies.AddRange(model);
            _dbContext.SaveChanges();

            return Ok();
        }

        //[HttpPut]
        //public virtual async Task<IActionResult> Update([FromBody] CurrencyDto tDto)
        //{
        //    var model = _mapper.Map<Currency>(tDto);

        //    _dbContext.Currencies.Update(model);
        //    _dbContext.SaveChanges();

        //    return Ok();
        //}

        //[HttpPut]
        //public virtual async Task<IActionResult> UpdateRange([FromBody] IList<CurrencyDto> tDto)
        //{
        //    var model = _mapper.Map<List<Currency>>(tDto);

        //    _dbContext.Currencies.UpdateRange(model);
        //    _dbContext.SaveChanges();

        //    return Ok();
        //}


        //[HttpDelete]
        //public virtual async Task<IActionResult> Delete([FromBody] CurrencyDto tDto)
        //{
        //    var model = _mapper.Map<Currency>(tDto);

        //    _dbContext.Currencies.Remove(model);
        //    _dbContext.SaveChanges();

        //    return Ok();
        //}

        //[HttpDelete]
        //public virtual async Task<IActionResult> DeleteRange([FromBody] IList<CurrencyDto> tDto)
        //{
        //    var model = _mapper.Map<List<Currency>>(tDto);

        //    _dbContext.Currencies.UpdateRange(model); 
        //    _dbContext.SaveChanges();

        //    return Ok();
        //}

    }
}
