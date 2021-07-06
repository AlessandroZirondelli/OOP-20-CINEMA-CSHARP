using OOP20_CINEMA_CSHARP.Zirondelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_20_CINEMA_CSHARP.Zirondelli
{
    class SorterByHall : ISorter<IProgrammedFilm>
    {
        
        public IComparer<IProgrammedFilm> GetComparer()
        {
            return null;

            
        }
    }
}
