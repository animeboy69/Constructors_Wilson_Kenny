using System;

namespace Constructors_Wilson_Kenny
{
    class Program
    {
        /// <summary>
        /// Tells the user what there favorite game is and what type of game it is.
        /// </summary>
        /// <param name="args">Tells what the name of the game is called.</param>
        static void Main(string[] args)
        {

            
           Game myGame = new Game("Call of Duty MW2" , "FPS");

            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre} game!");

            Game myOtherGame = new Game();

            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is a {myOtherGame.genre}!");
        }
    }
}
