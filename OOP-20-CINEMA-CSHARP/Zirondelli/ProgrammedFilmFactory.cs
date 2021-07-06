using OOP20_CINEMA_CSHARP.Zirondelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_20_CINEMA_CSHARP.Zirondelli
{
    class ProgrammedFilmFactory : IProgrammedFilmFactory
    {
        public IProgrammedFilm createProgrammedFilm(int idFilm, Hall hall, double price, DateTime date, DateTime startTime, DateTime endTime)
        {
            return new ProgrammedFilm(idFilm, hall, price, date, new TimeSlot(startTime, endTime));
        }
    }
}
