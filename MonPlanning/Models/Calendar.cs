using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonPlanning.Models
{
    public class Calendar
    {
        readonly string month;
        readonly int daysCount, code;
        readonly int[] days;

        public Calendar(int _code, string _month, int _daysCount)
        {
            code = _code;
            month = _month;
            daysCount = _daysCount;
            days = new int[_daysCount];

            for (var i = 0; i < _daysCount; i++)
            {
                days[i] = i + 1;
            }
        }

        public string Month => month;
        public int Code => code;
        public int DaysCount => daysCount;
        public int[] Days => days;
    }
}
