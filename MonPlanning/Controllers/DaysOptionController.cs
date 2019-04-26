using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonPlanning.Models;

namespace MonPlanning.Controllers
{
    [Route("planning/[controller]")]
    [ApiController]
    public class DaysOptionController : ControllerBase
    {
        readonly ContexteDonnees data;

        public DaysOptionController(ContexteDonnees _data)
        {
            data = _data;
        }

        // GET: planning/DaysOption
        [HttpGet]
        public ActionResult<IEnumerable<DaysOption>> Get()
        {
            return data.OptionsByValue.Values.ToList();
        }

        // GET: planning/DaysOption/5
        [HttpGet("{value}")]
        public ActionResult<DaysOption> GetOption(string value)
        {
            return data.OptionsByValue[value];
        }

        // POST: api/DaysOption
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //TODO
        }

        // PUT: api/DaysOption/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //TODO
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO
        }
    }
}
