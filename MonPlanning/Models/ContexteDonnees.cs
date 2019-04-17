using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonPlanning.Models
{
    public class ContexteDonnees
    {
        private Dictionary<int, Employee> employeesList;
        private Dictionary<int, Calendar> months;

        public ContexteDonnees()
        {
            employeesList = new Dictionary<int, Employee>();
            months = new Dictionary<int, Calendar>();
        }

        public void AddEmployee(Employee employee)
        {
            employeesList.Add(employee.Id ,employee);
        }

        public void AddMonth(Calendar month)
        {
            months.Add(month.Code, month);
        }

        public IReadOnlyDictionary<int, Employee> EmployeeById => employeesList;
        public IReadOnlyDictionary<int, Calendar> MonthById => months;
    }
}
