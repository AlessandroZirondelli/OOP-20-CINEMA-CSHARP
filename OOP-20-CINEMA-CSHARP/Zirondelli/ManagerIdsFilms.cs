using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_CINEMA_CSHARP.Zirondelli
{
    public class ManagerIdsFilms : IManagerIdsFilms
    {
        private readonly ICollection<int> containerFilmsIds;
        private readonly IIdsGenerator idsGenerator;

        public ManagerIdsFilms() 
        {
            containerFilmsIds = new HashSet<int>();
            idsGenerator = new IdsGenerator();
        }
        public ManagerIdsFilms( IdsGenerator idsGenerator)
        {
            this.containerFilmsIds = new HashSet<int>();
            this.idsGenerator = idsGenerator;
        }

        public int ? GetLastGeneratedId()
        {
            return this.idsGenerator.GetLastGeneratedId();
        }

        public ICollection<int> GetUsedIDs()
        {
            return containerFilmsIds;
        }
        public int GetNewFilmID()
        {
            int id = idsGenerator.GetNewId();
            containerFilmsIds.Add(id);
            return id;
        }
         public ICollection<int> getUsedIDs()
        {
            return containerFilmsIds;
        }
        public override String ToString()
        {
            return containerFilmsIds.ToString() + idsGenerator.ToString();
        }
        
        public void RemoveFilmId(int idToDelete)
        {
            containerFilmsIds.Remove(idToDelete);
        }
    }
}
