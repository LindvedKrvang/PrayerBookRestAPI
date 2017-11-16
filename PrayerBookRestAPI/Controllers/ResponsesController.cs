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
    [Route("api/Responses")]
    public class ResponsesController : Controller
    {
        private IResponseService _service;

        public ResponsesController(IResponseService responseService)
        {
            _service = responseService;
        }
        // GET: api/Responses
        [HttpGet]
        public IEnumerable<ResponseBO> Get()
        {
            return _service.GetAll();
        }

        // GET: api/Responses/5
        [HttpGet("{id}", Name = "GetResponse")]
        public IActionResult Get(int id)
        {
            return Ok(_service.Get(id));
        }
        
        // POST: api/Responses
        [HttpPost]
        public IActionResult Post([FromBody]ResponseBO value)
        {
            return Ok(_service.Create(value));
        }
        
        // PUT: api/Responses/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]ResponseBO value)
        {
            if (id != value.Id) return BadRequest("The id of the response must match the given id...");
            return Ok(_service.Update(value));
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_service.Delete(id));
        }
    }
}
