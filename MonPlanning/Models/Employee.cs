using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonPlanning.Models
{
    public class Employee
    {
        private string firstName, lastName;
        private int id;

        public Employee(int _id, string _firstName, string _lastName)
        {
            id = _id;
            firstName = _firstName;
            lastName = _lastName;
        }

        public string FirstName => firstName;
        public string LastName => lastName;
        public int Id => id;
    }
}
