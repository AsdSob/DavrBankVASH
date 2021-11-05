using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using VASHApi.Helpers;

namespace VASHApi.Services
{

    public interface IPageResponseService
    {
        PageResponse<TDto> GetPageResponse<TModel, TDto>(IEnumerable<TModel> entities, SortPageRequest pageRequest);
    }

    public class PageResponseService : IPageResponseService
    {
        private readonly IMapper _mapper;

        public PageResponseService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public PageResponse<TDto> GetPageResponse<TModel, TDto>(IEnumerable<TModel> entities, SortPageRequest pageRequest)
        {
            var sortExpression = pageRequest.sort.ToOrderExpression<TModel>();

            var items = entities.AsQueryable().OrderBy(sortExpression);

            var dtos = _mapper.Map<IList<TDto>>(items).ToArray();

            var pageResponse = new PageResponse<TDto>()
            {
                Page = pageRequest.page == 0 ? 1 : pageRequest.page,
                PageSize = pageRequest.pagesize == 0 ? 20 : pageRequest.pagesize,
                Items = dtos,
                Total = dtos.Count(),
            };

            return pageResponse;
        }


    }
}
