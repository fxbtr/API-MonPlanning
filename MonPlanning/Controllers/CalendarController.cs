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
    public class CalendarController : ControllerBase
    {
        readonly ContexteDonnees data;

        public CalendarController(ContexteDonnees _data)
        {
            data = _data;
        }

        // GET: planning/Calendar
        [HttpGet]
        public ActionResult<IEnumerable<Calendar>> Get()
        {
            return data.MonthById.Values.ToList();
        }

        // GET: planning/Calendar/5
        [HttpGet("{code}", Name = "Get")]
        public ActionResult<Calendar> GetEmployee(int code)
        {
            return data.MonthById[code];
        }

        // POST: planning/Calendar
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //TODO
        }

        // PUT: planning/Calendar/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //TODO
        }

        // DELETE: planning/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO
        }
    }
}
