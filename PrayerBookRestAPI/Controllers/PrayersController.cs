using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrayerBookBLL.BusinessObjects;
using PrayerBookBLL.Interfaces;

namespace PrayerBookRestAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Prayers")]
    public class PrayersController : Controller
    {
        private readonly IPrayerService _service;

        public PrayersController(IPrayerService service)
        {
            _service = service;
        }

        // GET: api/Prayers
        [HttpGet]
        public IEnumerable<PrayerBO> Get()
        {
            return _service.GetAll();
        }

        // GET: api/Prayers/5
        [HttpGet("{id}", Name = "GetPrayer")]
        public IActionResult Get(int id)
        {
            return BadRequest();
        }
        
        // POST: api/Prayers
        [HttpPost]
        public IActionResult Post([FromBody]PrayerBO value)
        {
            return Ok(_service.Create(value));
        }
        
        // PUT: api/Prayers/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]string value)
        {
            return BadRequest();
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return BadRequest();
        }
    }
}
