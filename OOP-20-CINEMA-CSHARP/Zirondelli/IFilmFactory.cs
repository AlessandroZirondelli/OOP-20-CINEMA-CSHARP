using OOP20_CINEMA_CSHARP.Zirondelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_20_CINEMA_CSHARP.Zirondelli
{
    interface IFilmFactory
    {
        IFilm createBasicFilm(string name, string genre, string description, string  coverPath, int duration);
        IFilm createBasicFilmById(string name,string genre, string description, string  coverPath, int duration, int id);
    }
}
