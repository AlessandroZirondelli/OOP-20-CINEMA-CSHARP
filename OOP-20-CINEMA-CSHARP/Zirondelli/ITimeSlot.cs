using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_CINEMA_CSHARP.Zirondelli
{
    public interface ITimeSlot
    {
        DateTime StartTime { get; }
        DateTime EndTime { get; }

    }
}
