using OOP20_CINEMA_CSHARP.Zirondelli;
using System;
using System.Collections.Generic;

namespace OOP20_CINEMA_CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            IFilm f = new Film(12,"Spiderman","Action", 150, "Nice", null);
            IFilm f2 = new Film(13, "Batman", "Action", 150, "Nice", null);
            IFilm f3 = new Film(14, "Ironman", "Action", 150, "Nice", null);
            IFilm f4 = new Film(15, "Thor", "Action", 150, "Nice", null);

            IProgrammedFilm pf = new ProgrammedFilm(1,Hall.HALL_1,3.5,DateTime.Now,new TimeSlot(DateTime.Now,DateTime.Now));
            Console.WriteLine(pf);


            IContainerFilmsModel container = new ContainerFilmsModel();
            container.AddFilm(f);
            container.AddFilm(f2);
            container.AddFilm(f3);
            container.AddFilm(f4);
            

          
            foreach (var element in container.GetFilms())
            {
                Console.WriteLine(element);
            }

            container.RemoveFilm(f2);
            Console.WriteLine("------------");
            foreach (var element in container.GetFilms())
            {
                Console.WriteLine(element);
            }


        }
    }
}
