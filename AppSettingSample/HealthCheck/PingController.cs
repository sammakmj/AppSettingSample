using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppSettingSample.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AppSettingSample.HealthCheck
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class PingController : Controller  // ControllerBase
    {
        private readonly AppSettings _appSettings;

        public PingController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        [Route("ping")]
        public IActionResult Ping()
        {
            var environment = _appSettings.Environment;
            return Ok(environment);
        }

        //// GET: api/Ping
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Ping/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Ping
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Ping/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
