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
        private ContexteDonnees data;

        public EmployeesController(ContexteDonnees _data)
        {
            data = _data;
        }

        // GET planning/employees
        [HttpGet]
        public ActionResult<IEnumerable<int>> Get()
        {
            return data.EmployeeById.Keys.ToList();
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
        }

        // PUT planning/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE planning/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
