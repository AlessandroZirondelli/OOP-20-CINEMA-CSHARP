using System.Collections.Generic;
using System;

namespace csharp.LorenzoSansone
{
	public interface IBookingModel
	{
		
		ISet<ITicket> Ticket { get; }
		
		ISet<ISeat> GetSeatsFromProgrammedFilm(IProgrammedFilm programmedFilm);
		
		void ButtonSelected(ISeat seat, IProgrammedFilm programmedFilm);
		
		void NewBooking();
		
		ISet<ISeat> SeatsSelected { get; }
		
		
		void DeleteTicket(IFilm film);
		
		void DeleteTicket(IProgrammedFilm programmedFilm);
	}

}