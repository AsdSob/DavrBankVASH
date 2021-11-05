
namespace VASHApi.Services
{
    public class SortPageRequest
    {
        /// <summary>
        /// Current page
        /// </summary>
        public int page { get; set; }

        /// <summary>
        /// Page size
        /// </summary>
        public int pagesize { get; set; }

        /// <summary>
        /// Sorting by field
        /// </summary>
        public string sort { get; set; }
    }

    public class SortRequestFilter : SortPageRequest, IFieldFilter
    {
        /// <summary>
        /// Filters
        /// </summary> 
        public FieldFilter[] Filters { get; set; }
    }
}
