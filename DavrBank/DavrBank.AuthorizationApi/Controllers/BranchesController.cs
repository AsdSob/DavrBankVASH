using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace DavrBank.AuthorizationApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BranchesController
    {

        //[HttpGet]
        //public virtual async Task<IActionResult> GetAll([FromQuery] SortRequestFilter requestFilter)
        //{
        //    //Convert filter array to expression
        //    var exp = requestFilter.Filters.FiltersToExpression<TModel>();

        //    //Get entities filtered with expression
        //    var models = await _dbContext.GetEntities(exp);

        //    //Set page response
        //    var pageResponse = _pageResponseService.GetPageResponse<TModel, TDto>(models, requestFilter);

        //    return Ok(pageResponse);
        //}

        //[HttpGet("{id}")]
        //public virtual async Task<IActionResult> GetSingle(int id)
        //{
        //    var model = await _dbContext.GetEntity<TModel>(id);
        //    var dto = _mapper.Map<TDto>(model);
        //    return Ok(dto);
        //}
    }
}
