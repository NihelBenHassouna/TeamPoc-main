using ApiThree.Contexts;
using ApiThree.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiThree.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     public class LinkController : ControllerBase
    {
        private readonly RadioDbContext _context;
        IRadioRepository radioRepository;
        public LinkController(RadioDbContext context)
        {
            _context = context;
            radioRepository = new RadioRepository();

        }
 
        [HttpGet("/getAllRadio/")]
        public object getAllRadio() {  return radioRepository.getRadio(_context);  }

        [HttpGet("/getRadioById/{id}")]
        public object GetByRadioById(String id) {return radioRepository.getByIdRadio(_context, id); }

        [HttpPost("/getFiles/")]
        public void getFilesFromFtp([FromBody] Ftp ftp)
        {radioRepository.getFiles(_context, ftp);}

        [HttpPost]
        public void PostRadio([FromBody] Input radio){radioRepository.PostFiles(_context, radio);}

    }
}