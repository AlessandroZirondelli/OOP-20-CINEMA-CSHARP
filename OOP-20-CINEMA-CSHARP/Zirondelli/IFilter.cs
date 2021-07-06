﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_20_CINEMA_CSHARP.Zirondelli
{
    interface IFilter<TItem>
    {
        Predicate<TItem> GetPredicate();
    }
}
