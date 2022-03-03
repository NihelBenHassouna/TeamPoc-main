using ApiFour.Contexts;
using ApiFour.Models;
using Microsoft.AspNetCore.Mvc;
 using System;

namespace ApiFour.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     public class AggController : ControllerBase
    {
        private readonly AggDbContext _context;
        IAggRepository AggRepository;
        public AggController(AggDbContext context)
        {
            _context = context;
            AggRepository = new AggRepository();

        }
 
        [HttpGet("/getAllAgg/")]
        public object getAllAgg() {  return AggRepository.getAgg(_context);  }

        
        [HttpPost("/AddAgg/")]
        public void AddAgg([FromBody] Agg AGG_SLOT_HOURLY) {
            AggRepository.AddAgg(_context, AGG_SLOT_HOURLY);
        }

        [HttpPost("/getAllAggBetweenDatesNotWorking/")]
        public object getAgg_Between_Date1_U_Date2([FromBody] Dates dates ) {

            return AggRepository.
                getAgg_Between_Date1_U_Date2(_context, dates.date1, dates. date2);
        }

    }
}