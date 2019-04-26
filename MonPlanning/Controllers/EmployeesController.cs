using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonPlanning.Models;

namespace MonPlanning.Controllers
{
    [Route("planning/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        readonly ContexteDonnees data;

        public EmployeesController(ContexteDonnees _data)
        {
            data = _data;
        }

        // GET planning/employees
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return data.EmployeeById.Values.ToList();
        }

        // GET planning/employees/5
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            return data.EmployeeById[id];
        }

        // POST planning/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //TODO
        }

        // PUT planning/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //TODO
        }

        // DELETE planning/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO
        }
    }
}
