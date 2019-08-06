using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Elmosify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class fController : ControllerBase
    {
        // GET: api/f
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/f/5
        [HttpGet("{id}", Name = "Getterthje")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/f
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/f/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
