using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_CINEMA_CSHARP.Zirondelli
{
    public interface IManagerIdsFilms
    {
        /** 
        * Get new film id. 
        * */
        int GetNewFilmID();
        /** 
         * Get used films ids.
         * */
        ICollection<int> GetUsedIDs();
        /** 
         * Get last generated id.
         * */
        int ? GetLastGeneratedId();
        /** 
         * Remove film id from container.
         * */
        void RemoveFilmId(int idToDelete);
    }
}
