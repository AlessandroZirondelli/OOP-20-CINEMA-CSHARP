using System;
using System.Collections.Generic;
using System.Text;

namespace OOP20_CINEMA_CSHARP.Zirondelli
{
    public interface IFilm
    {
		/// Get film id.
		int ID { get; }
		/// Get film name.
		string Name { get; }
		/// Get film genre.
		string Genre { get; }
		/// Get film duration.
		int Duration { get; }
        /// Get optional cover path where image is stored.
        string CoverPath { get; }
		/// Get film description.
		string Description { get; }


	}
}
