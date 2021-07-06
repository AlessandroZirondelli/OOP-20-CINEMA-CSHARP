using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_20_CINEMA_CSHARP.Zirondelli
{
    class HandlerList<TItem> : IHandlerList<TItem>
    {
        public IList<TItem> FilterBy(IList<TItem> list,  IFilter<TItem> filter)
        {
            return null;
        }

        public IList<TItem> SorterBy(IList<TItem> list, ISorter<TItem> sorter)
        {
            throw new NotImplementedException();
        }
    }
}
