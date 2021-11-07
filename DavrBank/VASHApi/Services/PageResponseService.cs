using System.Collections.Generic;
using System.Linq;
using VASHApi.Helpers;

namespace VASHApi.Services
{

    public interface IPageResponseService
    {
        PageResponseModel<TDto> GetPageResponse<TDto>(IEnumerable<TDto> dtos, SortPageRequest pageRequest);
        PageResponseModel<TDto> GetPageResponse<TDto>(IEnumerable<TDto> dtos);
    }

    public class PageResponseService : IPageResponseService
    {

        public PageResponseModel<TDto> GetPageResponse<TDto>(IEnumerable<TDto> entities, SortPageRequest pageRequest)
        {
            var sortExpression = pageRequest.sort.ToOrderExpression<TDto>();

            var items = entities.AsQueryable().OrderBy(sortExpression).ToArray();

            var pageResponse = new PageResponseModel<TDto>()
            {
                Page = pageRequest.page == 0 ? 1 : pageRequest.page,
                PageSize = pageRequest.pagesize == 0 ? 20 : pageRequest.pagesize,
                Items = items,
                Total = items.Count(),
            };

            return pageResponse;
        }

        public PageResponseModel<TDto> GetPageResponse<TDto>(IEnumerable<TDto> entities)
        {
            var pageResponse = new PageResponseModel<TDto>()
            {
                Page = 1,
                PageSize = 20,
                Items = entities.ToArray(),
                Total = entities.Count(),
            };

            return pageResponse;
        }


    }
}
