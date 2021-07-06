using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_CINEMA_CSHARP.Zirondelli
{
    public interface IIdsGenerator
    {
        public int GetNewId();
        public int ?GetLastGeneratedId();
    }
}
