using OOP20_CINEMA_CSHARP.Zirondelli;
using System;
using System.Collections.Generic;
using System.Linq;
namespace csharp.LorenzoSansone
{
	public class BookingModelImpl : IBookingModel
	{ 
		private ISet<ITicket> setTicket;
		private ISet<ISeat> seatSelected;

		public BookingModelImpl( ISet<ITicket> setTicket)
		{
			this.seatSelected = new HashSet<ISeat>();
			this.setTicket = setTicket;
		}

		public ISet<ITicket> Ticket
		{
			get
			{
				return setTicket;
			}
		}
		public ISet<ISeat> GetSeatsFromProgrammedFilm(IProgrammedFilm programmedFilm)
		{
			
			ISet<ISeat> setSeatRet = new HashSet<ISeat>();
			foreach(var ticket in setTicket)
			{
				if (ticket.Id == programmedFilm.IdProgrammation
					&& ticket.Date.Equals(programmedFilm.Date)
					&& ticket.Time.Equals(programmedFilm.StartTime)
					&& ticket.Hall.Equals(programmedFilm.Hall))
				{
					
					foreach(var el in ticket.SetSeat)
					{
						setSeatRet.Add(el);
					}
				}		
			}
			return setSeatRet;
		}
		public void ButtonSelected(ISeat seat, IProgrammedFilm programmedFilm)
		{

			ISet<ISeat> set = this.GetSeatsFromProgrammedFilm(programmedFilm);
			if (!set.Contains(seat))
			{
				if (seatSelected.Contains(seat))
				{
					seatSelected.Remove(seat);
				}
				else
				{
					seatSelected.Add(seat);
				}
			}

		}
		
		public void NewBooking()
		{
			seatSelected = new HashSet<ISeat>();
		}

		public  ISet<ISeat> SeatsSelected
		{
			get
			{
				return seatSelected;
			}
		}
		private bool CondDeleteTicketFilm(ITicket ticket, IFilm film)
		{
			return ticket.Id == film.ID;
		}
		public void DeleteTicket(IFilm film)
		{
			setTicket = setTicket.Where(ticket => ticket.Id != film.ID).ToHashSet();
		}
		
		public void DeleteTicket(IProgrammedFilm programmedFilm)
		{
			setTicket = setTicket.Where(ticket => !(ticket.Id == programmedFilm.IdProgrammation
					&& ticket.Date.Equals(programmedFilm.Date)
					&& ticket.Time.Equals(programmedFilm.StartTime)
					&& ticket.Hall.Equals(programmedFilm.Hall)) ).ToHashSet();
		}
		
	}

}