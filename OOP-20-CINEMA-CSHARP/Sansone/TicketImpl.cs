using System;

using System.Collections.Generic;

namespace csharp.LorenzoSansone { 
	public class TicketImpl : ITicket
	{
		private readonly DateTime date;
		private readonly DateTime time;
		private readonly ISet<ISeat> setSeat;
		private readonly double price;
		private readonly int id;
		private readonly Hall hall;

		public TicketImpl(DateTime time, DateTime date, ISet<ISeat> setSeat, double price, int id, Hall hall)
		{
			this.date = date;
			this.hall = hall;
			this.setSeat = setSeat;
			this.price = price;
			this.id = id;
			this.time = time;
		}
		
		public DateTime Time
		{
			get
			{
				return time;
			}
		}
		public DateTime Date
		{
			get
			{
				return date;
			}
		}
		public ISet<ISeat> SetSeat
		{
			get
			{
				return setSeat;
			}
		}

		public double Price
		{
			get
			{
				return price;
			}
		}
	
		public int Id
		{
			get
			{
				return id;
			}
		}
		
		public Hall Hall
		{
			get
			{
				return hall;
			}
		}

		public override bool Equals(object obj)
		{
			return obj is TicketImpl impl &&
				   time == impl.time &&
				   id == impl.id &&
				   hall == impl.hall;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(time, id, hall);
		}

		public override string ToString()
		{
			return "TicketImpl [time=" + time + ", setSeat=" + setSeat + ", price=" + price + ", id=" + id + ", hall=" + hall + "]";
		}
		

	}

}