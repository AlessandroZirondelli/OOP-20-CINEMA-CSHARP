using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_CINEMA_CSHARP.Zirondelli
{
    public class ContainerFilmsModel : IContainerFilmsModel
    {   
        private ISet<IFilm> containerFilms;
        private IManagerIdsFilms manager;

        public ContainerFilmsModel()
        {
            containerFilms = new HashSet<IFilm>();
            manager = new ManagerIdsFilms();
        }
        public ContainerFilmsModel(ISet<IFilm> container, IManagerIdsFilms manager)
        {
            this.containerFilms = container;
            this.manager = manager;
        }

        public void AddFilm(IFilm newFilm)
        {
            this.containerFilms.Add(newFilm);
        }

        public ISet<IFilm> GetFilms()
        {
            return this.containerFilms;
        }

        public IManagerIdsFilms GetManagerIdsFilms()
        {
            return this.manager;
        }

        public void RemoveFilm(IFilm oldFilm)
        {
            this.containerFilms.Remove(oldFilm);
        }

        public override String ToString()
        {
            return "" + containerFilms + "" + manager;
        }
    }
}
