using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KhssApi.Controllers
{
    [Route("api/[controller]")]
    
    public class ValueController : ControllerBase
    {
        // GET: api/Value
        [HttpGet]
        [Produces("application/wahib+json")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Value/5
        [HttpGet("{id:int}")]
        public IActionResult Get(int id , string query)
        {
            return Ok(new Value { Id = id, Text = "Value "+ id });
        }

        // POST: api/Value
        [HttpPost]
        public IActionResult Post([FromBody] Value value)
        {
            if (!ModelState.IsValid)
            {
               return BadRequest(ModelState);
            }
            return CreatedAtAction("Get", new { id = value.Id } , value);
        }

        // PUT: api/Value/5
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

    public class Value
    {
        public int Id { get; set; }

        [MinLength(3)]
        public string Text { get; set; }
    }
}
