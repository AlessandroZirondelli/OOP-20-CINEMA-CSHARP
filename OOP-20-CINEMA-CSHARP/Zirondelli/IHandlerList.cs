using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_20_CINEMA_CSHARP.Zirondelli
{
    interface IHandlerList<TItem>
    {
        IList<TItem> FilterBy(IList<TItem> list, IFilter<TItem> filter);
        IList<TItem> SorterBy(IList<TItem> list, ISorter<TItem> sorter);
        
    }
}
