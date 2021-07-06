using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_CINEMA_CSHARP.Zirondelli
{
    public interface IProgrammedFilm
    {
        int IdProgrammation { get; }
        /**
         * Get hall number.
         */
        Hall Hall { get; }
        /**
         * Get film programmation price.
         */
        double ProgrammationPrice { get; }
        /**
         * Get date.
         */
        DateTime Date { get; }
        /**
         * Get start time.
         */
        DateTime StartTime { get; }
        /**
         * Get end time.
         */
        DateTime EndTime { get; }
    }
}
