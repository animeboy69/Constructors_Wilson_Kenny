using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Wilson_Kenny
{
    class Game
    {


        public string title, genre;

        public Game(string titleParm = "Unknown Title" , string genreParam = "Casual")
        {
            title = titleParm;
            genre = genreParam;
        }
    }
}
