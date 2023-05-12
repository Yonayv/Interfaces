using System;

namespace Interfaces
{
    /// <summary>
    /// the main method the game object passes through the title, genre, & esrb arguments
    /// the describe PlayGame method is called in the game genre instance & string is printed to the console
    /// the movie object passes through the title, genre, & esrb arguments
    /// the Describe & PlayMovie methods on the movie object are printed to the console.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("E", "FPS", "ZombCube");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movie myMovie = new Movie("PG", "Adventure/Comedy", "Sonic the Hedgehog 2");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
