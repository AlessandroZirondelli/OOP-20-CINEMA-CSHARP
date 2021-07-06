using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_CINEMA_CSHARP.Zirondelli
{
    public interface IContainerFilmsModel
    {
        /** 
        * Add film to the container.  
        * */
        void AddFilm(IFilm newFilm);
        /** 
         * Remove film from the container.
         * */
        void RemoveFilm(IFilm oldFilm);
        /** 
         * Get all films from the container.
         * */
        ISet<IFilm> GetFilms();
        /** 
         * Get manager ids films.
         * */
        IManagerIdsFilms GetManagerIdsFilms();
    }
}
