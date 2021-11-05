using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavrBank.AuthorizationApi.Services
{
    public class PageResponse<TDto>
    {
        /// <summary>
        /// Current page
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Page size
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Total finded items
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Items of current page
        /// </summary>
        public TDto[] Items { get; set; }

    }
}
