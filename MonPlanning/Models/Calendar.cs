using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonPlanning.Models
{
    public class Calendar
    {
        private string month;
        private int daysCount, code;

        public Calendar(int _code, string _month, int _daysCount)
        {
            code = _code;
            month = _month;
            daysCount = _daysCount;
        }

        public string Month => month;
        public int Code => code;
        public int DaysCount => daysCount;
    }
}
