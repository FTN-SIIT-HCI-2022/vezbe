using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Vezbe_Projekat.model
{
    public class BusinessHours
    {
        public BusinessHours()
        {

        }
        public BusinessHours(DayOfWeek day, TimeOnly startTime, TimeOnly endTime)
        {
            Day = day;
            StartTime = startTime;
            EndTime = endTime;
        }

        public DayOfWeek Day { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }


        public override string ToString()
        {
            return Day.ToString() + " : " + StartTime.ToString() + " - " + EndTime.ToString();
        }
    }
}
