using System.Collections.Generic;
using System.Threading.Tasks;
using DavrBank.Vash.Server.DataAccess;
using DavrBank.Vash.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DavrBank.Vash.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        protected readonly DataContext _dbContext;

        public CurrencyController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<List<Currency>> Get()
        {
            return  await _dbContext.Currencies.ToListAsync();


        }
    }
}
