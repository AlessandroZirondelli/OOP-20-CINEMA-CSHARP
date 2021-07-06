using OOP20_CINEMA_CSHARP.Zirondelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_20_CINEMA_CSHARP.Zirondelli
{
    public class FilmFactory : IFilmFactory
    {

        private ManagerIdsFilms managerIds; /** Manager for film ids. It's used to assign a new id for a new film. */
        public FilmFactory( ManagerIdsFilms managerIds)
        {
            this.managerIds = managerIds;
        }
        public IFilm createBasicFilm(string name, string genre, string description, string coverPath, int duration)
        {
            return new Film(managerIds.GetNewFilmID(), name, genre, duration, description, coverPath);
        }

        public IFilm createBasicFilmById(string name, string genre, string description, string coverPath, int duration, int id)
        {
            return new Film(id, name, genre, duration, description, coverPath);
        }
    }
}
