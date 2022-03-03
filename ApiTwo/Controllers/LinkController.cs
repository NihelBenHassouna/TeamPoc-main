using ApiTwo.Contexts;
using ApiTwo.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     public class LinkController : ControllerBase
    {
        private readonly LinkDbContext _context;
        ILinkRepository radioRepository;
        public LinkController(LinkDbContext context)
        {
            _context = context;
            radioRepository = new LinkRepository();

        }
 
        [HttpGet("/getAllLink/")]
        public object getAllRadio() {  return radioRepository.getRadio(_context);  }

        [HttpGet("/getLinkById/{id}")]
        public object GetByRadioById(String id) {return radioRepository.getByIdRadio(_context, id); }

        [HttpPost("/getFiles/")]
        public void getFilesFromFtp([FromBody] Ftp ftp)
        {radioRepository.getFiles(_context, ftp);}

        [HttpPost]
        public void PostRadio([FromBody] Input radio){radioRepository.PostFiles(_context, radio);}

    }
}