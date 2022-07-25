using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TidsregApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TidsregApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TidsregController : ControllerBase
    {
        // GET: api/<TidsregController>
        [HttpGet("GetReg")]
        public List<Registrering> Get()
        {
            return TidsregDAL.registrering;
        }
        // POST api/<TidsregController>
        [HttpPost("PostReg")]
        public List<Registrering> Post([FromBody] Registrering registrering)
        {
          
            TidsregDAL.registrering.Add(registrering);
            
            return TidsregDAL.registrering;

        }

        // GET api/<TidsregController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

       
        // PUT api/<TidsregController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TidsregController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
