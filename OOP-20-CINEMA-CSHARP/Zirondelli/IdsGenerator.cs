using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_CINEMA_CSHARP.Zirondelli
{
    public class IdsGenerator : IIdsGenerator
    {
        private int ? lastGeneratedId;
        public IdsGenerator() 
        {
            this.lastGeneratedId = null;
        }
        public int ?GetLastGeneratedId()
        {
            return this.lastGeneratedId;
        }

        public int GetNewId()
        {
            if (this.lastGeneratedId.HasValue) {
                this.lastGeneratedId = this.lastGeneratedId +1;
                return this.lastGeneratedId.Value;
            }
            this.lastGeneratedId = 0;
            return this.lastGeneratedId.Value;
        }
    }
}
