using ApiOne.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     public class LinkController : ControllerBase
    {
         ILinkRepository radioRepository;
        public LinkController()
        {
             radioRepository = new LinkRepository();

        }
 
      
        [HttpPost("/generateFileLink/")]
        public void generateFileLink([FromBody] Ftp ftp)
        {radioRepository.generateFileLink( ftp);}

       
    }
}