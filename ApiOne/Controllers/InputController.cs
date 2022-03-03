using ApiOne.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiOne.Controllers
{
    [Route("api/[controller]")]
      public class InputController : ControllerBase
    {
         IInputRepository inputRepository;
        public InputController( )
        {
           
        }
 
 
        [HttpPost("/generateFileInput/")]
        public void generateFileInput([FromBody] Ftp ftp)
        { inputRepository.generateFileInput( ftp);}

     
 
    }
}