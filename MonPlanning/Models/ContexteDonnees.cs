using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonPlanning.Models
{
    public class ContexteDonnees
    {
        private Dictionary<int, Employee> employeesList;

        public ContexteDonnees()
        {
            employeesList = new Dictionary<int, Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employeesList.Add(employee.Id ,employee);
        }

        public IReadOnlyDictionary<int, Employee> EmployeeById => employeesList;
    }
}
