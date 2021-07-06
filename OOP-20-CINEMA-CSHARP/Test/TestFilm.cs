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
        public void Prova() 
        {
            IList<int> list = new List<int>();
            IManagerIdsFilms manager = new ManagerIdsFilms(new IdsGenerator());
            Assert.True(manager.GetLastGeneratedId().Equals(null));
            Assert.Equal(1, manager.GetNewFilmID());
            Assert.Equal(1, manager.GetLastGeneratedId().Value);
            Assert.Equal(2, manager.GetLastGeneratedId().Value);
            Assert.Equal(3, manager.GetLastGeneratedId().Value);

            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.Equal(list, manager.GetUsedIDs());

            list.Clear();
            manager.RemoveFilmId(2);

            list.Add(1);
            list.Add(3);

            Assert.Equal(list, manager.GetUsedIDs());
            manager.GetNewFilmID();
            list.Add(4);
            Assert.Equal(list, manager.GetUsedIDs());

        }
    }
}
