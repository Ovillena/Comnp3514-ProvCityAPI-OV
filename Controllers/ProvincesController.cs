using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using provCityCode1st.Data;
using provCityCode1st.Models;

namespace provCityCode1st.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("ProvCityPolicy")]
    public class ProvincesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProvincesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Provinces
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provinces>>> GetProvinces()
        {
            return await _context.Provinces
            .Include(i => i.CityId)
            .ToListAsync();
        }

        // GET: api/Provinces/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Provinces
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Provinces/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Provinces/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
