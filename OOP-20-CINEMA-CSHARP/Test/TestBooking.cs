using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using csharp.LorenzoSansone;
using System.Linq;
using OOP20_CINEMA_CSHARP.Zirondelli;

namespace csharp.LorenzoSansone
{
    public class Classe
    {
        [Fact]
        public void TestModelSeat()
        {
            DateTime date = new DateTime(2008, 6, 1, 0, 0, 0);
            DateTime timeStart = new DateTime(2008, 6, 1, 7, 47, 0);
            DateTime timeEnd = new DateTime(2008, 6, 1, 8, 40, 0);

            ISet<ISeat> setSeat = new HashSet<ISeat>();
            ISet<ISeat> setSeat1 = new HashSet<ISeat>();

            ISet<ITicket> setTicket = new HashSet<ITicket>();

            ISeat seat1 = new SeatImpl(Row.B, 10);
            ISeat seat2 = new SeatImpl(Row.D, 10);
            ISeat seat3 = new SeatImpl(Row.G, 10);

            setSeat.Add(seat1);
            setSeat.Add(seat2);
            setSeat.Add(seat3);

            setSeat1.Add(seat1);
            setSeat1.Add(seat2);

            ITicket ticket1 = new TicketImpl( timeStart,date, setSeat, 10, 1, Hall.HALL_1);
            ITicket ticket2 = new TicketImpl( timeStart,date, setSeat1, 10, 2, Hall.HALL_2);

            setTicket.Add(ticket1);
            setTicket.Add(ticket2);

            IBookingModel model = new BookingModelImpl(setTicket);
            ITimeSlot timeSlot = new TimeSlot(timeStart, timeEnd);
            IProgrammedFilm programmedFilm = new ProgrammedFilm(2, Hall.HALL_2, 10, date, timeSlot);
            ISet<ISeat> setReturned = model.GetSeatsFromProgrammedFilm(programmedFilm);
           
            Assert.Equal(setSeat1,setReturned);
        }

        [Fact]
        public void TestDeleteTicketFromFilm()
        {
            DateTime date = new DateTime(2021,7,1,0,0,0);
            DateTime timeStart = new DateTime(2021, 7, 1, 7, 40, 9);
            ISet<ISeat> setSeat = new HashSet<ISeat>();
            ISet<ISeat> setSeat1 = new HashSet<ISeat>();
            ISet<ITicket> setTicket = new HashSet<ITicket>();

            ISeat seat1 = new SeatImpl(Row.A, 10);
            ISeat seat2 = new SeatImpl(Row.B, 10);
            ISeat seat3 = new SeatImpl(Row.A, 11);
            ISeat seat4 = new SeatImpl(Row.A, 12);

            setSeat.Add(seat1);
            setSeat.Add(seat2);
            setSeat1.Add(seat3);
            setSeat1.Add(seat4);

            ITicket ticket = new TicketImpl(timeStart, date, setSeat, 10, 1, Hall.HALL_1);
            ITicket ticket1 = new TicketImpl(timeStart, date, setSeat1, 10, 1, Hall.HALL_2);

            setTicket.Add(ticket);
            setTicket.Add(ticket1);

            IBookingModel model = new BookingModelImpl(setTicket);
            IFilm film = new Film(1, "Holly", "action", 10, "Amazing", "");
            model.DeleteTicket(film);
            Assert.Equal(new HashSet<ITicket>(),model.Ticket);
        }
        [Fact]
        public void TestDeleteTicketFromPogrammedFilm()
        {
            DateTime date = new DateTime(2008, 7, 1, 0, 0, 0);
            DateTime timeStart = new DateTime(2008, 7, 1, 7, 48, 0);
            DateTime timeEnd = new DateTime(2008, 7, 1, 8, 48, 0);

            ISet<ISeat> setSeat = new HashSet<ISeat>();
            ISet<ISeat> setSeat1 = new HashSet<ISeat>();
            ISet<ITicket> setTicket = new HashSet<ITicket>();


            ISeat seat1 = new SeatImpl(Row.A, 10);
            ISeat seat2 = new SeatImpl(Row.B, 11);
            ISeat seat3 = new SeatImpl(Row.C, 12);
            ISeat seat4 = new SeatImpl(Row.D, 13);
            ISeat seat5 = new SeatImpl(Row.E, 14);

            setSeat.Add(seat1);
            setSeat.Add(seat2);
            setSeat.Add(seat3);

            setSeat1.Add(seat4);
            setSeat1.Add(seat5);

            ITicket ticket = new TicketImpl(timeStart, date, setSeat, 10, 1, Hall.HALL_1);
            ITicket ticket1 = new TicketImpl(timeStart, date, setSeat1, 10, 2, Hall.HALL_2);

            setTicket.Add(ticket);
            setTicket.Add(ticket1);

            IBookingModel model = new BookingModelImpl(setTicket);
            ITimeSlot timeSlot = new TimeSlot(timeStart, timeEnd);
            IProgrammedFilm programmedFilm = new ProgrammedFilm(1, Hall.HALL_1, 10, date, timeSlot);
            model.DeleteTicket(programmedFilm);
            setTicket.Remove(ticket);
            Assert.Equal(setTicket, model.Ticket);

        }
    }
}
