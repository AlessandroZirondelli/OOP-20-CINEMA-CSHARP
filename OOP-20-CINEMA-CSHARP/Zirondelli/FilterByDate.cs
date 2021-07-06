using OOP20_CINEMA_CSHARP.Zirondelli;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_20_CINEMA_CSHARP.Zirondelli
{
    class FilterByDate : IFilter<IProgrammedFilm>
    {
        DateTime localDate; // date

        public FilterByDate(DateTime localDate)
        {
            this.localDate = localDate;
        }

        public Predicate<IProgrammedFilm> GetPredicate()
        {
            return pf => pf.Date.Equals(localDate.Date);
        }
    }
}
