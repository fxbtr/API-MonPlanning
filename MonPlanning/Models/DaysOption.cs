using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonPlanning.Models
{
    public class DaysOption
    {
        private string option, value;

        public DaysOption(string _option, string _value)
        {
            option = _option;
            value = _value;
        }

        public string Option => option;
        public string Value => value;
    }
}
