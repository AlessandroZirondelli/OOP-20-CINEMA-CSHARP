using System;
using System.Collections.Generic;

namespace csharp.LorenzoSansone
{
	public interface ITicket
	{
		DateTime Time { get; }
		ISet<ISeat> SetSeat { get; }
		double Price { get; }
		int Id { get; }
		Hall Hall { get; }

		DateTime Date { get; }
	}
}