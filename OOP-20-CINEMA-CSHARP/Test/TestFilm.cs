using OOP20_CINEMA_CSHARP.Zirondelli;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OOP20_CINEMA_CSHARP.Test
{   
    public class TestFilm
    {
        [Fact]
        public void TestManagerIdsFilms() 
        {
            IList<int> list = new List<int>();
            IManagerIdsFilms manager = new ManagerIdsFilms(new IdsGenerator());
            Assert.True(manager.GetLastGeneratedId().Equals(null));
            Assert.Equal(0, manager.GetNewFilmID());
            Assert.Equal(0, manager.GetLastGeneratedId().Value);
            Assert.Equal(1, manager.GetNewFilmID());
            Assert.Equal(1, manager.GetLastGeneratedId().Value);
            Assert.Equal(1, manager.GetLastGeneratedId().Value);

            list.Add(0);
            list.Add(1);
            Assert.Equal(list, manager.GetUsedIDs());

            list.Clear();
            manager.RemoveFilmId(1);

            list.Add(0);

            Assert.Equal(list, manager.GetUsedIDs());
            manager.GetNewFilmID();
            list.Add(2);
            Assert.Equal(list, manager.GetUsedIDs());

        }

        [Fact]
        void testContainerFilms()
        {
            IContainerFilmsModel container = new ContainerFilmsModel();
            IManagerIdsFilms manager = new ManagerIdsFilms(new IdsGenerator());

            IFilm f1 = new Film(0, "Name1", "Genre1", 120, "Description1", null);
            IFilm f2 = new Film(1, "Name2", "Genre2", 120, "Description1", null);
            IFilm f3 = new Film(2, "Name3", "Genre3", 120, "Description1", null);

            container.AddFilm(f1);
            container.AddFilm(f2);
            container.AddFilm(f3);

            ISet<IFilm> set = new HashSet<IFilm>();
            set.Add(f1);
            set.Add(f2);
            set.Add(f3);

            Assert.Equal(container.GetFilms(),set);
            container.RemoveFilm(f3);
            set.Remove(f3);
            Assert.Equal(container.GetFilms(), set);
        }





    }
}
