using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace code.Entities
{
    public class HourContract
    {
        public DateTime Date { get; private set; }
        public int Hours { get; private set; }
        public double ValuePerHour { get; private set; }

        public HourContract(DateTime date, int hours, double valuePerHour)
        {
            Date = date;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}