using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_CINEMA_CSHARP.Zirondelli
{
    public class TimeSlot : ITimeSlot
    {
        DateTime startTime;
        DateTime endTime;

        public TimeSlot(DateTime startTime, DateTime endTime)
        {
            this.startTime = startTime;
            this.endTime = endTime;
          
        }
        public DateTime StartTime
        {
            get { return this.startTime; }
        }
        public DateTime EndTime
        {
            get { return this.endTime; }
        }

        public override string ToString()
        {
            return "" + this.startTime + " "+ this.endTime;
        }
    }
}
