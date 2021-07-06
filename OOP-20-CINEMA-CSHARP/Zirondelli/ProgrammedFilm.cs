using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_CINEMA_CSHARP.Zirondelli
{
    public class ProgrammedFilm : IProgrammedFilm
    {
        private readonly int id; // reference to idFilms
        private readonly Hall hall;
        private readonly double price;
        private readonly DateTime date;
        private readonly ITimeSlot timeSlot;

        public ProgrammedFilm(int id, Hall hall, double price, DateTime date, ITimeSlot timeSlot)
        {
            this.id = id;
            this.hall = hall;
            this.price = price;
            this.date = date;
            this.timeSlot = timeSlot;
        }

        public int IdProgrammation
        {
            get { return this.id; }
        }

        public Hall Hall
        {
            get { return this.hall; }
        }

        public double ProgrammationPrice
        {
            get { return this.price; }
        }

        public DateTime StartTime
        {
            get { return this.timeSlot.StartTime; }
        }

        public DateTime EndTime
        {
            get { return this.timeSlot.EndTime; }
        }

        public DateTime Date
        {
            get { return this.timeSlot.EndTime; }
        }

        public override bool Equals(object obj)
        {
            return obj is ProgrammedFilm film &&
                   id == film.id &&
                   hall == film.hall &&
                   price == film.price &&
                   date == film.date &&
                   EqualityComparer<ITimeSlot>.Default.Equals(timeSlot, film.timeSlot);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, hall, price, date, timeSlot);
        }

        public override string ToString()
        {
            return "" + this.id + " " + this.hall + " " + this.price + " " + this.date + " " + this.timeSlot;
        }
    }
}
