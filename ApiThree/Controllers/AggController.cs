using ApiThree.Contexts;
using ApiThree.Models;
using Microsoft.AspNetCore.Mvc;
 using System;

namespace ApiThree.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     public class AggController : ControllerBase
    {
        private readonly AggDbContext _context;
        private readonly InputDbContext _contextInput;
        private readonly RadioDbContext _contextRadio;

        IAggRepository AggRepository;
        public AggController(AggDbContext context, InputDbContext contextInput, RadioDbContext contextRadio)
        {
            _context = context;
            _contextInput = contextInput;
            _contextRadio = contextRadio;
            AggRepository = new AggRepository();

        }
 
        [HttpGet("/getAllAgg/")]
        public object getAllAGG_SLOT_HOURLY() {  return AggRepository.getAllAgg(_context);  }

        
        [HttpPost("/AddAgg/")]
        public void PostAGG_SLOT_HOURLY([FromBody] Agg AGG_SLOT_HOURLY) { AggRepository.AddAgg(_context, AGG_SLOT_HOURLY);}

        [HttpPost("/getAgg_Between_Date1_U_Date2/")]
        public object getAGG_SLOT_HOURL_Between_Date1_U_Date2([FromBody] Dates dates ) {

            return AggRepository.getAgg_Between_Date1_U_Date2(_context, dates.date1, dates. date2);
        }

    //    [HttpPut("/update/{{date}}")]
        [HttpPost("/update/")]
        public void update() {
           

            return AggRepository.update(_context,_contextInput,_contextRadio);  // date
        }



    }
}