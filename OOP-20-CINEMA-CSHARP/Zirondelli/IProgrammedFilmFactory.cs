using OOP20_CINEMA_CSHARP.Zirondelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_20_CINEMA_CSHARP.Zirondelli
{
    interface IProgrammedFilmFactory
    {
        IProgrammedFilm createProgrammedFilm(int idFilm, Hall hall, double price, DateTime date, DateTime startTime, DateTime endTime);
    }
}
