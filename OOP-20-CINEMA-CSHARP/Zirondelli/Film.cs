using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_CINEMA_CSHARP.Zirondelli
{
    public class Film : IFilm
    {
        private readonly int id;
        private readonly string name;
        private readonly string genre;
        private readonly int duration;
        private readonly string description;
        private readonly string coverImagePath;

        public Film(int id, string name, string genre, int duration, string description, string coverImagePath)
        {
            this.id = id;
            this.name = name;
            this.genre = genre;
            this.duration = duration;
            this.description = description;
            this.coverImagePath = coverImagePath;
        }

        public int ID {
            get { return this.id; }
        }

        public string Name {
            get { return this.name; }
        }

        public string Genre
        {
            get { return this.genre; }
        }

        public int Duration 
        {
            get { return this.duration; }
        }

        public string CoverPath
        {
            get { return this.coverImagePath; }
        }

        public string Description 
        {
            get { return this.description; }
        }

        public override string ToString()
        {
            return ""+this.id+" "+this.name+" "+this.genre+" "+this.Duration+" "+this.description+" "+this.coverImagePath;
        }
        public override bool Equals(object obj)
        {
            return obj is Film film &&
                   id == film.id &&
                   name == film.name &&
                   genre == film.genre &&
                   duration == film.duration &&
                   description == film.description &&
                   coverImagePath == film.coverImagePath;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, name, genre, duration, description, coverImagePath);
        }
    }
}