using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /// <summary>
    /// the class Movie is implemented by the interface IGenre
    /// automatic properties get & set have been made for ESRB, Title, and Genre
    /// the assigned params are set to the corresponding properties
    /// the public method PlayMovie, prints "Movie is Starting, Sssshhh", to console.
    /// the Describe method that returns a string that, describes the game & includes the title, genre, & esrb
    ///
    /// </summary>
    class Movie : IGenre
    {
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Movie(String esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, SSsssshhhhh! ");
        }


        public string Describe()
        {
            return $"{Title} is a {Genre} movie, rated {Esrb}";
        }
    }
}
