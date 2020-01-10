using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            this._context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetVlues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);  // OK returns http 200
        }

        [HttpGet("{id}")]
        // GET api/values/5
        public IActionResult GetValues(int id)
        {
            var values = _context.Values.FirstOrDefault(x => x.id == id);
            return Ok(values);
        }

        [HttpPost]
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
