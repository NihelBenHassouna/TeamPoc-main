using ApiThree.Contexts;
using ApiThree.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiThree.Controllers
{
    [Route("api/[controller]")]
      public class InputController : ControllerBase
    {
        private readonly InputDbContext _context;
        IInputRepository inputRepository;
        public InputController(InputDbContext context)
        {
            _context = context;
            inputRepository = new InputRepository();

        }
 
        [HttpGet("/getAllInput/")]
        public object getAllInput() {  return inputRepository.getAllInput(_context);  }

        [HttpGet("/GetByInputByNeId/{id}")]
        public object GetByInputByNeId(String id) {return inputRepository.GetByInputByNeId(_context, id); }

        [HttpPost("/getFilesFromFtp/")]
        public void getFilesFromFtp([FromBody] Ftp ftp)
        { inputRepository.getFilesFromFtp(_context, ftp);}

        [HttpPost]
        public void PostInput([FromBody] Link power) { inputRepository.PostInput(_context, power); }

 
    }
}