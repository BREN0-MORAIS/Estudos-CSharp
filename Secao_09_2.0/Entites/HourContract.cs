using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_09_2._0.Entites
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuesHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
           
        }

        public HourContract(DateTime date, double valuesHour, int hours)
        {
            Date = date;
            ValuesHour = valuesHour;
            Hours = hours;
        }


        public double TotalValue()
        {
            return Hours * ValuesHour;
        }
    }
}
