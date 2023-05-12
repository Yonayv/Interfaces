using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /// <summary>
    ///  The class Game implements the IGenre interface
    ///  the implemented constructor takes the string params; genre, esrb, & title
    ///  automatic properties get & set the esrb, title, & genre and are assigned to the corresponding properties
    ///  the public method PlayGame prints "Game is starting", to console
    ///  the Desrcibe method returns the string that desvribes the game & includes the title, genre, & esrb
    /// </summary>
    class Game : IGenre
    {
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Game(String esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        public void PlayGame()
        {
            Console.WriteLine($"{Title} is a genre {Genre} ");
        }

        public string Describe()
        {
            return $"{Title} is a {Genre} game, rated {Esrb}!";
        }
    }
}
