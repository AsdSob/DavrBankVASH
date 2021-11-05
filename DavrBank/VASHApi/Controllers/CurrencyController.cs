using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VASHApi.Entities;

namespace VASHApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        public CurrencyController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Currency> Get()
        {
            var entities = new List<Currency>();



            return entities;
        }

    }
}
